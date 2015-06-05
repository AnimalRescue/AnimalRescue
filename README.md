[![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/AnimalRescue/AnimalRescue?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)
`# AnimalRescue
AnimalRescue is a community-supported .NET project giving online capabilities to non-profit animal rescue organization.  It is intended to provide web-based access to intake, adoption, foster and volunteer management, veterinary services, medical records, and push interfaces to a number of nationwide pet adoption web sites (just to name a few)

## Developer Workflow

The project management board currently resides at petrescue.visualstudio.com and is closed to the original team at this time. The GitHub repository is open for pull requests from the community at large.  

###Abbreviations used are:

* API 
  * **_AP_**plication **_I_**nterface
  * A contractually defined mechanism, generally implemented as an interface, following SemVer rules
* ATDD 
  * **_A_**cceptance **_T_**est **_D_**riven **_D_**evelopment
* BDD 
  * **_B_**ehavioral **_D_**riven **_D_**evelopment
* CR 
  * **_C_**ode **_R_**eview
* PO 
  * **_P_**roduct **_O_**wner
* PR 
  * **_P_**ull **_R_**equest 
  * Merge into one Git branch to another, usually triggering an intervening build to validate the source code
* SemVer
  * **_Sem_**antic **_Ver_**sioning
  * http://semver.org/
* TDD 
  * **_T_**est **_D_**riven **_D_**evelopment
* UAC 
  * **_U_**ser **_A_**cceptance **_C_**riteria
* UI 
  * **_U_**ser **_I_**nterface
* UX 
  * **_U_**ser e**_X_**perience

The approved developer workflow is as follows:

* Use Visual Studio 2013 or above and integrate to TFS at the above site
* Epics
  * Epics are broad topics describing major system capabilities
  * Review with the team and especially the Product Owner (PO)
* Features
  * Create one or more Features that satisfy each of the Epics, described above
  * Groom with the PO and generate a set of UAC's
  * Link the Epics back to the Features
* User Stories
  * Create a list of User Stories to satisfy the Epics, mentioned above
  * Review with the PO and genrate specific UAC's for the story
  * Link the User Story to an Epic or Feature (preferably the Epic)
  * Create a set of BDD tests using specflow to satisfy each UAC in the story
  * Update the UI framework to provide tests for each UAC, if appropriate
    * Appropriate means that it creates any testable change in the UI at all
* Tasks
  * In grooming, create a set of Tasks that satisfy the associated User Story
  * Always link Tasks back to the User Story
  * Document edge cases and expected results from the Task
* Development
  * Create a branch named after the task you are working on
  * Create UAC tests first in SpecFlow
  * Implement UI tests in the framework
  * Use TDD in all development
    * Red, green, refactor (don't forget the refactor)
    * Unit tests should be totally confined within an assembly, using mocks/substitutes at bountries
    * Integration tests should be written for interactions _between_ assemblies (two or more)
    * UAC tests (acceptance tests) are written to evidence observable behavior from _outside_ of the system (UI, API, etc.)
  * Always try to work with a pair partner
  * Commit every time you go green on a new/fixed test
    * To associate a commit with a work item, embed #_nnn_ in the commit message, where _nnn_ is the work item ID
    * Make commit messages descriptive of _why_ the change was made
    * Commit messages should be prefixed by the branch name (ex. - **T037: _commit message_**)
  * Push to the repository often
  * When a functional software state it reached, generate a pull request to the dev branch
    * Keep Pull Requests as small as possible - help the people doing the code reviews
      * A good rule of thumb is to try to do a PR daily 
  * When all builds go green for the last PR in a work item, delete the task branch (both locally and on the repository)

* Build and deploy
  * Create a branch and make your changes
  * Pull Request into the dev branch
    * Get two other team members not involved in the Task to do a Code Review (CR)
    * When approved, the PR is merged into Git
    * Build runs from the dev branch merged output (runs unit and integration tests)
      * if failure, all hands on deck
      * if success,
        * Invoke downstream build for acceptance tests
      * Invoke build to run downstream SpecFlow UI tests
      * If success,
        * Invoke downstream build for merge to master
        * Runs all unit, integration, acceptance, and UI tests
      * if success,
        * Invoke downstream build to deploy to production
