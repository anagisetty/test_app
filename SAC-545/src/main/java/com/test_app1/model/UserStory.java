package com.test_app1.model;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity 
@Table(name = "userstory")
public class UserStory {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String title;
    private String description;
    private String assignedTeamMember;
    private boolean fetchedFromJiraApi;

    public UserStory() {
    }

    public UserStory(Long id, String title, String description, String assignedTeamMember, boolean fetchedFromJiraApi) {
        this.id = id;
        this.title = title;
        this.description = description;
        this.assignedTeamMember = assignedTeamMember;
        this.fetchedFromJiraApi = fetchedFromJiraApi;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getAssignedTeamMember() {
        return assignedTeamMember;
    }

    public void setAssignedTeamMember(String assignedTeamMember) {
        this.assignedTeamMember = assignedTeamMember;
    }

    public boolean isFetchedFromJiraApi() {
        return fetchedFromJiraApi;
    }

    public void setFetchedFromJiraApi(boolean fetchedFromJiraApi) {
        this.fetchedFromJiraApi = fetchedFromJiraApi;
    }

}