# Hatfield's Environmental Data Management System: Data Aquisition Module  #

This repository contains the contains core functions/interfaces/systems used by Data Aquisition sub-modules to provide aquire data from local and remote locations. The Data Aquisition module does not contain any UI implementations; the UI is located in the Hatfield.EnviroData.MVC solution/repository.

Related repositories:
* Hatfield.EnviroData.Core: contains shared systems used by the web, QA and Data Acquisition systems (ie Database, Notification & File System systems)
*	Hatfield.EnviroData.MVC: provides all UI functions including admin & end-user access to view data, edit data, run QA systems, and configure/view/monitor DataAquisition systems. All web/UI systems will be implemented in this application/repository
*	Hatfield.EnviroData.QualityAssurance: contains functions/interfaces/systems used to provide analysis and quality assurance functions
*	Hatfield.EnviroData.FileSystems: contains functions/interfaces/systems to access file system. If works outside VPN, please download the dependencies DLLs in the release.
