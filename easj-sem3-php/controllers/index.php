<?php

require_once 'models/curl.php';

class IndexController{

    private $sessions;
    private $curl;

    public function __construct(Session $sessions){
        $this->sessions = $sessions;
        $this->curl     = new Curl();
    }


}

?>