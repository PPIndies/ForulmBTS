<?php include("views/navbar.php"); ?>
<?php
session_start();
 
$bdd = new PDO('mysql:host=127.0.0.1;dbname=idea_box', 'root', '');
 
if(isset($_GET['id']) AND $_GET['id'] > 0) {
   $getid = intval($_GET['id']);
   $requser = $bdd->prepare('SELECT * FROM user WHERE id = ?');
   $requser->execute(array($getid));
   $userinfo = $requser->fetch();
?>
<html>
   <head>
      <title>TUTO PHP</title>
      <meta charset="utf-8">
   </head>
   <body>
      <div align="center">
         <h2>Profil de <?php echo $userinfo['pseudo']; ?></h2>
         <br /><br />
         Pseudo = <?php echo $userinfo['pseudo']; ?>
         <br />
         Mail = <?php echo $userinfo['mail']; ?>
         <br />
         <?php
         if(isset($_SESSION['id']) AND $userinfo['id'] == $_SESSION['id']) {
         ?>
         <br />
         <a href="editprofil.php">Editer mon profil</a>
         <a href="deconnexion.php">Se déconnecter</a>
         <a href="forum.php">liste forum</a>
         <?php
         }
         ?>
      </div>
   </body>
</html>
<?php   
}