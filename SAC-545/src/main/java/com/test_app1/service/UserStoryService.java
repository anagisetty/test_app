package com.test_app1.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.test_app1.model.UserStory;
import com.test_app1.repository.UserStoryRepository;

@Service
public class UserStoryService {

    @Autowired
    private UserStoryRepository userStoryRepository;

    public List<UserStory> findByTitle(String title) {
        return userStoryRepository.findByTitle(title);
    }

    public List<UserStory> findByDescription(String description) {
        return userStoryRepository.findByDescription(description);
    }

    public List<UserStory> findByAssignedTeamMember(String assignedTeamMember) {
        return userStoryRepository.findByAssignedTeamMember(assignedTeamMember);
    }

    public List<UserStory> findByFetchedFromJiraApi(boolean fetchedFromJiraApi) {
        return userStoryRepository.findByFetchedFromJiraApi(fetchedFromJiraApi);
    }
}