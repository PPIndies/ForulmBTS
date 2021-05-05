<?php include("views/navbar.php"); ?>
<?php
echo "<script>alert('');</script>";
session_start();
$_SESSION = array();
session_destroy();
header("Location: connexion.php");
?>