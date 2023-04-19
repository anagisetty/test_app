package com.test_app1.model;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;

@Entity
public class UserStory { 
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	
	private String storyTitle; 
	
	private String storyDescription; 
	
	@ManyToOne 
	@JoinColumn(name = "assigned_team_member_id") 
	private AssignedTeamMember assignedTeamMember;
	
	public UserStory() { 
		
	}
	
	public UserStory(String storyTitle, String storyDescription, AssignedTeamMember assignedTeamMember) { 
		this.storyTitle = storyTitle; 
		this.storyDescription = storyDescription; 
		this.assignedTeamMember = assignedTeamMember; 
	}

	public Long getId() {
		return id;
	}

	public void setId(Long id) {
		this.id = id;
	}

	public String getStoryTitle() {
		return storyTitle;
	}

	public void setStoryTitle(String storyTitle) {
		this.storyTitle = storyTitle;
	}

	public String getStoryDescription() {
		return storyDescription;
	}

	public void setStoryDescription(String storyDescription) {
		this.storyDescription = storyDescription;
	}

	public AssignedTeamMember getAssignedTeamMember() {
		return assignedTeamMember;
	}

	public void setAssignedTeamMember(AssignedTeamMember assignedTeamMember) {
		this.assignedTeamMember = assignedTeamMember;
	}
	
	
}