# AnimalRescue

## Information

[![Documentation Status](https://readthedocs.org/projects/animalrescue/badge/?version=latest)](https://readthedocs.org/projects/animalrescue/?badge=latest)

[![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/AnimalRescue/AnimalRescue?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

## Purpose of the Project

AnimalRescue is a community-supported project giving online capabilities to non-profit animal rescue organizations.  It is intended to provide web-based access to intake, adoption, foster and volunteer management, veterinary services, medical records, and push interfaces to a number of nationwide pet adoption web sites (just to name a few)

## Developer Workflow

The project management board currently resides at github.com/AnimalRescue and is being developed by the original team at this time. After the initial structure and code base are created, the GitHub repository will be open for pull requests from the community at large.

Our current goal is to create this system using a .NET Core Standard 2.0 implementation

### Abbreviations used are

* API
  * **AP**plication **I**nterface
  * A contractually-defined mechanism, generally implemented as an interface, following SemVer 2.0 rules
* ATDD
  * ***A***cceptance ***T***est ***D***riven ***D***evelopment
* BDD
  * **B**ehavioral **D**riven ***D***evelopment
* CR
  * **C**ode **R**eview
* Epic
  * an Issue with a corresponding milestone (for filtering) and an Epic label
* Feature
  * an Issue with a corresponding milestone of the Epic it is contained in and a Feature label
  * link to its parent by putting #### Parent #parentIssueNumber as the first line of the description
* PO
  * **P**roduct **O**wner
* PR
  * **P**ull **R**equest
  * Request sent to upstream branch to pull in your branches code.  Usually triggering an intervening build to validate the source code
* SemVer
  * [Semantic Versioning](http://semver.org/)
* Task (used rarely)
  * An Issue with a corresponding milestone of the Epic its parent is contained in and a Task label
  * link to its parent by putting #### Parent #parentIssueNumber as the first line of the description
* TDD
  * **T**est **D**riven **D**evelopment
* UAC
  * **U**ser **A**cceptance **C**riteria
* UI
  * **U**ser **I**nterface
* User Story
  * An Issue with a corresponding milestone of the Epic its parent is contained in and a User Story label
  * link to its parent by putting #### Parent #parentIssueNumber as the first line of the description
* UX
  * **U**ser e**X**perience

The approved developer workflow is as follows:

* Epics
  * Epics are broad topics describing major system capabilities or subsystems
  * Review with the team and especially the Product Owner (PO)
  * Groom with the PO and generate a set of Features
* Features
  * Create one or more Features that satisfy each of the Epics, described above
  * Groom with the PO and generate a set of User Stories
  * Link all Issues to their logical parent by putting the Issue number of the parent into the initial description of the child Issue
* User Stories
  * Create a list of User Stories to satisfy the Features, mentioned above
  * Groom with the PO and genrate specific UAC's for the story
  * Link the User Story to its parent Feature
  * Create a set of BDD tests in the solution using XBehave to satisfy each UAC in the story
  * Update the UI framework to provide tests for each UAC, if appropriate
    * Appropriate means that it creates any testable change in the UI at all
* Tasks
  * In planning (if necessary), create a set of Tasks that satisfy the associated User Story
  * Always link Tasks back to the User Story
  * Document edge cases and expected results from the Task
  * Include a set of tests showing criteria indicating "done"
  * Generic tests or "test by example", as required
* Development
  * Create a fork of the repo
    * rebase back to the upstream dev branch frequently to avoid painful merge conflicts as much as possible
  * Create a branch on your fork named after the User Story/Task you are working on
  * Create UAC tests first in SpecFlow
  * Implement UI tests in the framework
  * Use TDD in all development
    * Red, green, refactor (don't forget the refactor)
    * Unit tests should be totally confined within an assembly, using mocks/substitutes at boundries
    * Integration tests should be written for interactions _between_ assemblies (two or more)
      * Use NSubstitute or custom-written stubs, mocks, spys, etc.
    * UAC tests (acceptance tests) are written to evidence observable behavior from _outside_ of the assembly or system (UI, API, etc.)
  * Always try to work with a pair partner
  * Commit every time you go green on a new/fixed test
    * To associate a commit with an item, embed #_nnn_ in the commit message, where _nnn_ is the item number
    * If the Item has an Owner, @mention them in the commit message so they can set up a code review
    * Make commit messages descriptive of _why_ the change was made
    * Commit messages should be prefixed by the branch name (ex. - **Issue0037: _commit message***)
      * Pad the numeric portion of the commit message to 4 digits to facilitate sorting and filtering
    * When a functional software state it reached, generate a pull request to the dev branch ASAP
    * Keep Pull Requests (**PR**) as small as possible - help the people doing the code reviews
      * A good rule of thumb is to try to do a PR daily or for each Item, whichever is quicker
  * When all builds go green for the last PR in a work item, one of the admin/originals team will invoke the Merge and delete your local branch when successful.

* Build and deploy
  * Do a PR into the dev branch from your feature branch
    * A build will be triggered to determine if
      * your branch can be merged safely into the repo's dev branch
      * the system builds and runs unit and integration tests
        * if failure, fix and we will build again when you update your fork's branch
        * if success,
          * Invoke downstream build for acceptance tests
        * Invoke build to run downstream UI (smoke) tests
        * If success,
          * Invoke downstream build for merge to master as Release build
          * Runs all unit, integration, acceptance, and UI tests
    * once build is successful, one or more of the Reviewers team will do a Code Review (**CR**)
    * When approved, the PR is merged by a Reviewer team member into repo
    * Another build will be triggered to deploy the system to the QA environment
      * Members of the QA team will test the deployment
      * If successful, a member will trigger another build
        * merge to the master branch
        * deploy to production