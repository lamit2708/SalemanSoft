## Copy TEA into PRO
- [] copy "\src\SaleManSoftUI\Code\company\TEA" template
- [] open powershell cd to "D:\workspace\src\SaleManSoftUI\Code\company\PRO"
- []  using below script ( noted: rename CTM and Customer for new name of Object according)
	Get-ChildItem -Recurse | Where-Object {$_.Name -cmatch "TEA"} | Rename-Item -NewName { $_.name -creplace 'TEA', 'CTM'} -verbose
	
	Get-ChildItem -Recurse | Where-Object {$_.Name -cmatch "Team"} | Rename-Item -NewName { $_.name -creplace 'Team', 'Customer'} -verbose

## rename objects inside code by visual studio code. Noted: Must select "Aa" icon to ensure matching search
- [] TEA => CTM
- [] Team => Product
- [] team=>product

## BUILD PROJECTS ORDER -- -- DATA > BUSSINESS
## NOTE: Should update lasted "visual Studio Code" version

