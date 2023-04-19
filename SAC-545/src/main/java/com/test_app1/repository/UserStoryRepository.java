package com.test_app1.repository;

import org.springframework.data.jpa.repository.JpaRepository;

public interface UserStoryRepository extends JpaRepository<UserStory, Long> { 
	
	List<UserStory> findAllByOrderByIdAsc(); 
	
	List<UserStory> findByStoryTitle(String storyTitle); 
	
	Optional<UserStory> findByStoryDescription(String storyDescription); 
	
	Optional<UserStory> findByAssignedTeamMember(AssignedTeamMember assignedTeamMember); 
	
	void deleteById(Long id); 
}