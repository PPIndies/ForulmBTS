<?php include("navbar.php"); ?>
<center>
<table class="forum" width="1250px>
   <tr class="header">
      <th class="main">Topics</th>
      <th class="sub-info messages hide-640">Réponses</th>

      <th class="sub-info dmessage">Createur</th>
   </tr>
   <?php
   while($c = $topic->fetch()) {

   ?>
   <tr class="categories">
      <td class="main">
         <h6><a href="forum_topics.php?categorie=<?= url_custom_encode($c['sujet']) ?>"><?= $c['sujet'] ?></a></h6>

      </td>
      <td class="sub-info hide-640"><?= get_nomcreateur($c['id']) ?></td>

      <td class="sub-info"><?= derniere_reponse_categorie($c['id']) ?></td>
   </tr>
   <?php } ?>
</table>
</center>
