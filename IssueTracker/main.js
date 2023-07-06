var issues;

function fetchIssues(){
     issues= JSON.parse(localStorage.getItem('issues'));
    var issuesList = document.getElementById('issuesList');
    issuesList.innerHTML='';
    for(var i = 0;i<issues.length;i++){
        for (var i = 0; i < issues.length; i++) {
            var id = issues[i].id;
            var desc = issues[i].description;
            var severity = issues[i].severity;
            var assignedTo = issues[i].assigned;
            var status = issues[i].status;
            
            issuesList.innerHTML +=   '<div class="well">'+
                                      '<h6>Issue ID: ' + id + '</h6>'+
                                      '<p><span class="label label-info">' + status + '</span></p>'+
                                      '<h3>' + desc + '</h3>'+
                                      '<p><span class="glyphicon glyphicon-time"></span> ' + severity + ' '+
                                      '<span class="glyphicon glyphicon-user"></span> ' + assignedTo + '</p>'+
                                      '<a href="#" class="btn btn-warning" onclick="setStatusClosed(\''+id+'\')">Close</a> '+
                                      '<a href="#" class="btn btn-danger" onclick="deleteIssue(\''+id+'\')">Delete</a>'+
                                      '</div>';
          }
    }
}

document.getElementById('issueForm').addEventListener('submit',saveIssue);

function saveIssue(e){
    // A guid for the issue is generated
    var issueId = chance.guid();
    var issueDescription = document.getElementById('issueDescription').value;
    var issueStatus = 'Open';
    var issueSeverity = document.getElementById('issueSeverity').value;
    var issueAssignedTo = document.getElementById('issueAssignedTo').value;
    var issue={
        id:issueId,
        description:issueDescription,
        status:issueStatus,
        severity: issueSeverity,
        assigned: issueAssignedTo

    }
    
    // If the local storage contains issues, gets the saved issues and adds the new one
    if(localStorage.getItem('issues') === null){
       var issues = [];
       issues.push(issue);
       localStorage.setItem('issues',JSON.stringify(issues));
    }else{
        issues = JSON.parse(localStorage.getItem('issues'));
        issues.push(issue);
        localStorage.setItem('issues',JSON.stringify(issues)) ;
    }
    
    document.getElementById('issueForm').reset();
    fetchIssues();
    e.preventDefault(); 
}

function setStatusClosed(id){

    issues.forEach(element => {
        if(element.id==id && element.status!='Closed'){
            element.status='Closed';
        }
    });

    localStorage.setItem('issues',JSON.stringify(issues));
    fetchIssues();
}

function deleteIssue(id){
    
    localStorage.setItem('issues',JSON.stringify(issues.filter(element=>{
        return element.id!=id;
    })));

    fetchIssues();
}

