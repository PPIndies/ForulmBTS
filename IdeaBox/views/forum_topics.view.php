<?php include("navbar.php"); ?>
<table class="forum">
   <tr class="header">
      <th class="main">Sujet</th>
      <th class="sub-info w10">Messages</th>
      <th class="sub-info w20">Dernier message</th>
      <th class="sub-info w20">Création</th>
   </tr>
   <?php while($t = $topics->fetch()) { ?>
   <tr>
      <td class="main">
         <h4><a href=""><a href="topic.php?titre=<?= url_custom_encode($t['sujet']) ?>&id=<?= $t['topic_base_id'] ?>"><?= $t['sujet'] ?></a></a></h4>
      </td>
      <td class="sub-info"><?= $t['date_heure_creation'] ?><br />par <?= $t['pseudo'] ?></td>
   </tr>
   <?php } ?>
</table>
<a href="nouveau_topic.php?categorie=<?= $id_categorie ?>">Créer un nouveau topic</a>