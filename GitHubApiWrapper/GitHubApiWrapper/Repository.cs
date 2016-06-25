using GitHubApiWrapper.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApiWrapper
{
    /// <summary>
    /// A single GitHub repository
    /// </summary>
    public class Repository : IRepository
    {
        public Repository(RepositoryJson repository)
        {
            this.Name = repository.Name;
            this.FullName = repository.full_name;
            this.Description = repository.Description;
            this.Private = repository.Private;
            this.Fork = repository.Fork;
            this.Url = repository.Url;
            this.HtmlUrl = repository.html_url;
            this.ArchiveUrl = repository.archive_url;
            this.AssigneesUrl = repository.assignees_url;
            this.BlobsUrl = repository.blobs_url;
            this.CloneUrl = repository.clone_url;
            this.CollaboratorsUrl = repository.collaborators_url;
            this.CommentsUrl = repository.comments_url;
            this.CommitsUrl = repository.commits_url;
            this.CompareUrl = repository.compare_url;
            this.ContentsUrl = repository.contents_url;
            this.ContributorsUrl = repository.contributors_url;
            this.DeploymentsUrl = repository.deployments_url;
            this.DownloadsUrl = repository.downloads_url;
            this.EventsUrl = repository.events_url;
            this.ForksUrl = repository.forks_url;
            this.GitCommitsUrl = repository.git_commits_url;
            this.GitRefsUrl = repository.git_refs_url;
            this.GitTagsUrl = repository.git_tags_url;
            this.GitUrl = repository.git_url;
            this.HooksUrl = repository.hooks_url;
            this.IssueCommentUrl = repository.issue_comment_url;
            this.IssueEventsUrl = repository.issue_events_url;
            this.IssuesUrl = repository.issues_url;
            this.KeysUrl = repository.keys_url;
            this.LabelsUrl = repository.labels_url;
            this.LanguagesUrl = repository.languages_url;
            this.MergesUrl = repository.merges_url;
            this.MilestonesUrl = repository.milestones_url;
            this.MirrorUrl = repository.mirror_url;
            this.NotificationsUrl = repository.notifications_url;
            this.PullsUrl = repository.pulls_url;
            this.ReleasesUrl = repository.releases_url;
            this.SshUrl = repository.ssh_url;
            this.StargazersUrl = repository.stargazers_url;
            this.StatusesUrl = repository.statuses_url;
            this.SubscribersUrl = repository.subscribers_url;
            this.SubscriptionUrl = repository.subscription_url;
            this.SvnUrl = repository.svn_url;
            this.TagsUrl = repository.tags_url;
            this.TeamsUrl = repository.teams_url;
            this.TreesUrl = repository.trees_url;
            this.Homepage = repository.Homepage;
            this.Language = repository.Language;
            this.ForksCount = repository.forks_count;
            this.StargazersCount = repository.stargazers_count;
            this.WatchersCount = repository.watchers_count;
            this.Size = repository.Size;
            this.DefaultBranch = repository.default_branch;
            this.OpenIssuesCount = repository.open_issues_count;
            this.HasIssues = repository.has_issues;
            this.HasWiki = repository.has_wiki;
            this.HasPages = repository.has_pages;
            this.HasDownloads = repository.has_downloads;
            this.PushedAt = repository.pushed_at;
            this.CreatedAt = repository.created_at;
            this.UpdatedAt = repository.updated_at;
        }

        public string Name { get; private set; }
        public string FullName { get; private set; }
        public string Description { get; private set; }
        public bool Private { get; private set; }
        public bool Fork { get; private set; }
        public string Url { get; private set; }
        public string HtmlUrl { get; private set; }
        public string ArchiveUrl { get; private set; }
        public string AssigneesUrl { get; private set; }
        public string BlobsUrl { get; private set; }
        public string BranchesUrl { get; private set; }
        public string CloneUrl { get; private set; }
        public string CollaboratorsUrl { get; private set; }
        public string CommentsUrl { get; private set; }
        public string CommitsUrl { get; private set; }
        public string CompareUrl { get; private set; }
        public string ContentsUrl { get; private set; }
        public string ContributorsUrl { get; private set; }
        public string DeploymentsUrl { get; private set; }
        public string DownloadsUrl { get; private set; }
        public string EventsUrl { get; private set; }
        public string ForksUrl { get; private set; }
        public string GitCommitsUrl { get; private set; }
        public string GitRefsUrl { get; private set; }
        public string GitTagsUrl { get; private set; }
        public string GitUrl { get; private set; }
        public string HooksUrl { get; private set; }
        public string IssueCommentUrl { get; private set; }
        public string IssueEventsUrl { get; private set; }
        public string IssuesUrl { get; private set; }
        public string KeysUrl { get; private set; }
        public string LabelsUrl { get; private set; }
        public string LanguagesUrl { get; private set; }
        public string MergesUrl { get; private set; }
        public string MilestonesUrl { get; private set; }
        public string MirrorUrl { get; private set; }
        public string NotificationsUrl { get; private set; }
        public string PullsUrl { get; private set; }
        public string ReleasesUrl { get; private set; }
        public string SshUrl { get; private set; }
        public string StargazersUrl { get; private set; }
        public string StatusesUrl { get; private set; }
        public string SubscribersUrl { get; private set; }
        public string SubscriptionUrl { get; private set; }
        public string SvnUrl { get; private set; }
        public string TagsUrl { get; private set; }
        public string TeamsUrl { get; private set; }
        public string TreesUrl { get; private set; }
        public string Homepage { get; private set; }
        public string Language { get; private set; }
        public int ForksCount { get; private set; }
        public int StargazersCount { get; private set; }
        public int WatchersCount { get; private set; }
        public string Size { get; private set; }
        public string DefaultBranch { get; private set; }
        public int OpenIssuesCount { get; private set; }
        public bool HasIssues { get; private set; }
        public bool HasWiki { get; private set; }
        public bool HasPages { get; private set; }
        public bool HasDownloads { get; private set; }
        public DateTime PushedAt { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
