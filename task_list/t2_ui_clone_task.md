## Copy TEA into PRO

## Example to rename from the module TEA (Team) into the module PRO (Product)

- [] Copy Folder TEA into Folder PRO
- [] Run the below script to rename TEA into PRO
  * Get-ChildItem -Recurse | Where-Object {$_.Name -cmatch "TEA"} | Rename-Item -NewName { $_.name -creplace 'TEA', 'PRO'} -verbose
- [] Run the below script to rename Team into Product
  * Get-ChildItem -Recurse | Where-Object {$_.Name -cmatch "TEA"} | Rename-Item -NewName { $_.name -creplace 'TEA', 'PRO'} -verbose

- [] Use Visual Studio Code to change (Note: Replace with match case)
  * TEA => PRO
  * Team => Product
  * team => product

