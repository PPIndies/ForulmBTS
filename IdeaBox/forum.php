<?php
require('php/functions.php');
session_start();
$bdd = new PDO('mysql:host=127.0.0.1;dbname=idea_box', 'root', ''); 
$categories = $bdd->query('SELECT * FROM f_categories ORDER BY nom');
$subcat = $bdd->prepare('SELECT * FROM f_souscategories WHERE id_categorie = ? ORDER BY nom');
require('views/forum.view.php');

?>