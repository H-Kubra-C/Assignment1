using Entities;
using RepositoryContracts;

namespace InMemoryRepository;

public class CommentInMemoryRepository : ICommentRepository
{
    public Task<Comment> AddAsync(Comment comment)
    {
    comment.Id = comments.Any(Comment comment)
        ?comment.Max(c => c.id) + 1
        : 1;
    comments.add(comment);
    return Task.FromResult(comment);
    
    }
    
    Public Task UpdateASync(Comment comment)
    {
        Comment? existingComment =
            comment.SingleOrDefault(c => c.Id == comment.Id);
        if (existingComment is null)
        {
            throw new InvalidOperationException(
                $"Comment with ID '{comment.Id}' not found");
        }

        comment.Remove(existingComment);

        comment.Add(comment);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(int id)
    { 
        Comment? commentToRemove = Comment.SingleOrDefault(c => c.Id == id);
        if (commentToRemove is null)
        {
            throw new InvalidOperationException(
                $"Comment with ID '{id}' not found");
        } comment.Remove(commentToRemove); return Task.CompletedTask; }
}
