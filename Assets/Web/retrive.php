<?php

include 'connection.php';

	$sql = "SELECT * FROM `user_road` ORDER BY 'score' Limit 5 ";

	$result = $con->query($sql);

	if ($result->num_rows <= 0) {
		echo "0";
	}
	else{
		echo $result->num_rows;
	}
	while ($col = $result->fetch_assoc()){
		echo "+" . $col['name'] . "+" . $col['score'] ;
	}

?>

