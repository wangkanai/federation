$dirs=[ordered]@{
    1="Federation";
    2="Identity";
    3="Security";
}

for ($i=0; $i -lt $dirs.count; $i++) {
	Push-Location $dirs[$i];
	$build = ".\" + $dirs[$i] + "\build.ps1";
	write-host $dirs[$i] -ForegroundColor Red;
	write-host $build    -ForegroundColor Green;
	.\build.ps1
	Pop-Location;
}
