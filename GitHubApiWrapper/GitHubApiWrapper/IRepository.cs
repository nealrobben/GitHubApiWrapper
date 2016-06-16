using System;

namespace GitHubApiWrapper
{
    public interface IRepository
    {
        string ArchiveUrl { get; }
        string AssigneesUrl { get; }
        string BlobsUrl { get; }
        string BranchesUrl { get; }
        string CloneUrl { get; }
        string CollaboratorsUrl { get; }
        string CommentsUrl { get; }
        string CommitsUrl { get; }
        string CompareUrl { get; }
        string ContentsUrl { get; }
        string ContributorsUrl { get; }
        DateTime CreatedAt { get; }
        string DefaultBranch { get; }
        string DeploymentsUrl { get; }
        string Description { get; }
        string DownloadsUrl { get; }
        string EventsUrl { get; }
        bool Fork { get; }
        int ForksCount { get; }
        string ForksUrl { get; }
        string FullName { get; }
        string GitCommitsUrl { get; }
        string GitRefsUrl { get; }
        string GitTagsUrl { get; }
        string GitUrl { get; }
        bool HasDownloads { get; }
        bool HasIssues { get; }
        bool HasPages { get; }
        bool HasWiki { get; }
        string Homepage { get; }
        string HooksUrl { get; }
        string HtmlUrl { get; }
        string IssueCommentUrl { get; }
        string IssueEventsUrl { get; }
        string IssuesUrl { get; }
        string KeysUrl { get; }
        string LabelsUrl { get; }
        string Language { get; }
        string LanguagesUrl { get; }
        string MergesUrl { get; }
        string MilestonesUrl { get; }
        string MirrorUrl { get; }
        string Name { get; }
        string NotificationsUrl { get; }
        int OpenIssuesCount { get; }
        bool Private { get; }
        string PullsUrl { get; }
        DateTime PushedAt { get; }
        string ReleasesUrl { get; }
        string Size { get; }
        string SshUrl { get; }
        int StargazersCount { get; }
        string StargazersUrl { get; }
        string StatusesUrl { get; }
        string SubscribersUrl { get; }
        string SubscriptionUrl { get; }
        string SvnUrl { get; }
        string TagsUrl { get; }
        string TeamsUrl { get; }
        string TreesUrl { get; }
        DateTime UpdatedAt { get; }
        string Url { get; }
        int WatchersCount { get; }

        string ToString();
    }
}