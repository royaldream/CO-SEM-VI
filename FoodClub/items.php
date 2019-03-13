<?php
    require ('connection.php');
    $sql = "SELECT * FROM food";
    $result = $con->query($sql);
    $res = array();
    while($row = $result->fetch_assoc()) {
        array_push($res,$row);
    }
    print_r(json_encode($res));
?>