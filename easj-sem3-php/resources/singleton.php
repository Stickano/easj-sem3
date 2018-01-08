<?php

@session_start();
require_once('resources/session.php');

final class Singleton {

    private static $instance;

    # View and Controller
    public static $page;
    public static $controller;

    # Session Handler
    public static $session;

    # Private constructor to ensure it won't be initialized
    private function __construct(){}

    /**
     * This is the initializer for this object
     * It will determine which View to load and its apropriate Controller
     * @return object This (only) instance 
     */
    public static function init(){
        if(!isset(self::$instance)){
            self::$instance = new self();
            self::$session = Session::init();
            self::getView();
            self::getController();
        }

        return self::$instance;
    }

    /**
     * This will determine which page(view) to load
     */
    private static function getView(){
        
        $pages = array();
        foreach (glob("views/*.php") as $file) {
            $page = substr($file, 6, -4);
            $pages[] = $page;
        }

        $search = array_intersect($pages, array_keys($_GET));
        if(in_array('index', $pages)){
            $pos = array_keys($pages, 'index')[0];
            self::$page = $pages[$pos];
        }
        
        if(!empty($search)){
            $search = array_values($search);
            self::$page = $search[0];
        }
    }

    /**
     * This will load the appropriate controller
     */
    public static function getController(){
        require_once('controllers/'.self::$page.'.php');
        $controller = ucfirst(self::$page).'Controller';
        self::$controller = new $controller(self::getConn(), self::getDb(), self::$session); 
    }

    /**
     * Will generate '&nbsp;'  
     * @param  int    $count The amount of spaces 
     * @return string        The spaces
     */
    public function spaces(int $count){
        $spaces = '';
        for($i=0; $i<$count; $i++){
            $spaces .= '&nbsp;';
        }
        return $spaces;
    }
}

?>
