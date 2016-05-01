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
    public class Repository
    {

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

    }
}
