package com.test_app1.service;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.test_app1.model.UserStory;
import com.test_app1.repository.UserStoryRepository;

@Service 
public class UserStoryService {

	@Autowired 
	private UserStoryRepository userStoryRepository; 

	public List<UserStory> findAllByOrderByIdAsc() {
		return userStoryRepository.findAllByOrderByIdAsc();
	}

	public List<UserStory> findByStoryTitle(String storyTitle) {
		return userStoryRepository.findByStoryTitle(storyTitle);
	}

	public Optional<UserStory> findByStoryDescription(String storyDescription) {
		return userStoryRepository.findByStoryDescription(storyDescription);
	}

	public Optional<UserStory> findByAssignedTeamMember(AssignedTeamMember assignedTeamMember) {
		return userStoryRepository.findByAssignedTeamMember(assignedTeamMember);
	}

	public void deleteById(Long id) {
		userStoryRepository.deleteById(id);
	}
}