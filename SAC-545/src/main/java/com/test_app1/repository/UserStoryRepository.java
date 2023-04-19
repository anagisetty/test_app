package com.test_app1.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import com.test_app1.model.UserStory;

public interface UserStoryRepository extends JpaRepository<UserStory, Long> {

    List<UserStory> findByTitle(String title);
    List<UserStory> findByDescription(String description);
    List<UserStory> findByAssignedTeamMember(String assignedTeamMember);
    List<UserStory> findByFetchedFromJiraApi(boolean fetchedFromJiraApi);
}