<?php

    require ('connection.php');
    $name = $_GET['name'];
    $mail = $_GET['mail'];
    $pass = $_GET['pass'];
    $sql = "INSERT INTO user VALUES('','".$_GET['name']."','".$_GET['mail']."','".$_GET['pass']."')";
    $result = mysqli_query($con,$sql);
    if($result){
        $res = json_encode("Usercreated Succefully");
        echo $res;
    }
?>