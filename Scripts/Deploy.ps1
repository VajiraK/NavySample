
Write-Host "********************************"
Write-Host "Removing old package"
Remove-Item "C:\Vajira\Navy\IIS" -Force -Recurse
Write-Host "Deploy new package"
Copy-Item "C:\Vajira\Navy\NavyRepo\NavySampleSite\NavySampleSite" -Recurse -Destination "C:\Vajira\Navy\IIS\NavySampleSite"
Write-Host "Deployment completed"
Write-Host "********************************"