<?php
require('php/functions.php');
session_start();
$bdd = new PDO('mysql:host=127.0.0.1;dbname=idea_box', 'root', ''); 
$topic = $bdd->query('SELECT * FROM f_topics ORDER BY id');
require('views/ListTopic.view.php');

?>