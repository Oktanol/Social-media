﻿namespace Social_media.Entities
{
    public class Users
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Posts> Posts { get; set; }
    public List<Comments> Comments { get; set; }
    public List<Likes> Likes { get; set; }
    }
}
