<?php

    # Singleton
    require_once('resources/singleton.php');
    $singleton = Singleton::init();

    # Shortcut for some commonly used classes
    $controller = $singleton::$controller;
    $session = $singleton::$session;

    echo'<title>3rd Semester Exam</title>';
    echo'<link rel="alternate" href="https://web.site" hreflang="dk" />';
    echo'<meta charset="utf-8" />';
    echo'<meta http-equiv="X-UA-Compatible" content="IE=edge" />';
    echo'<meta name="description" content="Exam Project for 3rd Semester, EASJ." />';
    echo'<meta name="keywords" content="EASJ, 3rd Semester, Exam Project, Computer Science" />';
    echo'<meta name="robots" content="noindex, nofollow" />';
    echo'<meta name="viewport" content="width=device-width, initial-scale=0.8" />';

    # Stylesheet(s)
    echo'<link href="css/styles.css" rel="stylesheet">';
?>