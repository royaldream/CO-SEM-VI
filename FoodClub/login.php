<?php
    $mail = $_GET['mail'];
    $pass = $_GET['pass'];
    require ('connection.php');
    $mail = $_GET['mail'];
    $pass = $_GET['pass'];
    $sql = "SELECT * FROM user";
    $result = $con->query($sql);
    $flag=0;
    while($row = $result->fetch_assoc()) {
        $t_mail = $row['emailid'];
        $t_pass = $row['password'];
        if($mail == $t_mail && $pass == $t_pass){
            $flag=1;
            break;
        }
    }
    if($flag){
        echo "LOGIN SUCCESSFULLY";
    }else{
        echo "ENTER CORECT DETAILS";
    }
?>