package com.test_app1.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.test_app1.model.UserStory;
import com.test_app1.service.UserStoryService;

@RestController
public class UserStoryController {

    @Autowired
    private UserStoryService userStoryService;

    @GetMapping("/userstories/title")
    public List<UserStory> findByTitle(@RequestParam("title") String title) {
        return userStoryService.findByTitle(title);
    }

    @GetMapping("/userstories/description")
    public List<UserStory> findByDescription(@RequestParam("description") String description) {
        return userStoryService.findByDescription(description);
    }

    @GetMapping("/userstories/assignedteam")
    public List<UserStory> findByAssignedTeamMember(@RequestParam("assignedTeamMember") String assignedTeamMember) {
        return userStoryService.findByAssignedTeamMember(assignedTeamMember);
    }

    @GetMapping("/userstories/fetchedfromjira")
    public List<UserStory> findByFetchedFromJiraApi(@RequestParam("fetchedFromJiraApi") boolean fetchedFromJiraApi) {
        return userStoryService.findByFetchedFromJiraApi(fetchedFromJiraApi);
    }
}