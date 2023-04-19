package com.test_app1.controller;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.test_app1.model.UserStory;
import com.test_app1.service.UserStoryService;

@RestController 
@RequestMapping("/user-stories") 
public class UserStoryController {
	
	@Autowired 
	private UserStoryService userStoryService; 

	@GetMapping("/all") 
	public List<UserStory> findAllByOrderByIdAsc() {
		return userStoryService.findAllByOrderByIdAsc();
	}

	@GetMapping("/title") 
	public List<UserStory> findByStoryTitle(@RequestParam String storyTitle) {
		return userStoryService.findByStoryTitle(storyTitle);
	}

	@GetMapping("/description/{storyDescription}") 
	public Optional<UserStory> findByStoryDescription(@PathVariable String storyDescription) {
		return userStoryService.findByStoryDescription(storyDescription);
	}

	@GetMapping("/team-member") 
	public Optional<UserStory> findByAssignedTeamMember(@RequestParam AssignedTeamMember assignedTeamMember) {
		return userStoryService.findByAssignedTeamMember(assignedTeamMember);
	}

	@DeleteMapping("/{id}") 
	public void deleteById(@PathVariable Long id) {
		userStoryService.deleteById(id);
	}

}