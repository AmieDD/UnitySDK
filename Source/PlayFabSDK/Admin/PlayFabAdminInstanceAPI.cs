#if ENABLE_PLAYFABADMIN_API
using System;
using System.Collections.Generic;
using PlayFab.AdminModels;
using PlayFab.Internal;
using PlayFab.Json;
using PlayFab.Public;

namespace PlayFab
{
    /// <summary>
    /// APIs for managing title configurations, uploaded Game Server code executables, and user data
    /// </summary>
    public class PlayFabAdminInstanceAPI
    {
        public PlayFabApiSettings ApiSettings = null;
        private PlayFabAuthenticationContext authenticationContext = null;

        public PlayFabAdminInstanceAPI() {}

        public PlayFabAdminInstanceAPI(PlayFabApiSettings settings) 
        {
            ApiSettings = settings;
        }

        public PlayFabAdminInstanceAPI(PlayFabAuthenticationContext context) 
        {
            authenticationContext = context;
        }

        public PlayFabAdminInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context) 
        {
            ApiSettings = settings;
            authenticationContext = context;
        }

        public void SetAuthenticationContext(PlayFabAuthenticationContext context)
        {
            authenticationContext = context;
        }

        public PlayFabAuthenticationContext GetAuthenticationContext()
        {
            return authenticationContext;
        }




        /// <summary>
        /// Clear the Client SessionToken which allows this Client to call API calls requiring login.
        /// A new/fresh login will be required after calling this.
        /// </summary>
        public void ForgetAllCredentials()
        {
            if(authenticationContext != null)
            {
                authenticationContext.ForgetAllCredentials();
            }
        }

        /// <summary>
        /// Abort an ongoing task instance.
        /// </summary>

        public void AbortTaskInstance(AbortTaskInstanceRequest request, Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/AbortTaskInstance", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Update news item to include localized version
        /// </summary>

        public void AddLocalizedNews(AddLocalizedNewsRequest request, Action<AddLocalizedNewsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/AddLocalizedNews", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Adds a new news item to the title's news feed
        /// </summary>

        public void AddNews(AddNewsRequest request, Action<AddNewsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/AddNews", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Adds a given tag to a player profile. The tag's namespace is automatically generated based on the source of the tag.
        /// </summary>

        public void AddPlayerTag(AddPlayerTagRequest request, Action<AddPlayerTagResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/AddPlayerTag", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Adds the game server executable specified (previously uploaded - see GetServerBuildUploadUrl) to the set of those a
        /// client is permitted to request in a call to StartGame
        /// </summary>

        public void AddServerBuild(AddServerBuildRequest request, Action<AddServerBuildResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/AddServerBuild", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Increments the specified virtual currency by the stated amount
        /// </summary>

        public void AddUserVirtualCurrency(AddUserVirtualCurrencyRequest request, Action<ModifyUserVirtualCurrencyResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/AddUserVirtualCurrency", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Adds one or more virtual currencies to the set defined for the title. Virtual Currencies have a maximum value of
        /// 2,147,483,647 when granted to a player. Any value over that will be discarded.
        /// </summary>

        public void AddVirtualCurrencyTypes(AddVirtualCurrencyTypesRequest request, Action<BlankResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/AddVirtualCurrencyTypes", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Bans users by PlayFab ID with optional IP address, or MAC address for the provided game.
        /// </summary>

        public void BanUsers(BanUsersRequest request, Action<BanUsersResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/BanUsers", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Checks the global count for the limited edition item.
        /// </summary>

        public void CheckLimitedEditionItemAvailability(CheckLimitedEditionItemAvailabilityRequest request, Action<CheckLimitedEditionItemAvailabilityResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/CheckLimitedEditionItemAvailability", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Create an ActionsOnPlayersInSegment task, which iterates through all players in a segment to execute action.
        /// </summary>

        public void CreateActionsOnPlayersInSegmentTask(CreateActionsOnPlayerSegmentTaskRequest request, Action<CreateTaskResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/CreateActionsOnPlayersInSegmentTask", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Create a CloudScript task, which can run a CloudScript on a schedule.
        /// </summary>

        public void CreateCloudScriptTask(CreateCloudScriptTaskRequest request, Action<CreateTaskResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/CreateCloudScriptTask", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Registers a relationship between a title and an Open ID Connect provider.
        /// </summary>

        public void CreateOpenIdConnection(CreateOpenIdConnectionRequest request, Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/CreateOpenIdConnection", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Creates a new Player Shared Secret Key. It may take up to 5 minutes for this key to become generally available after
        /// this API returns.
        /// </summary>

        public void CreatePlayerSharedSecret(CreatePlayerSharedSecretRequest request, Action<CreatePlayerSharedSecretResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/CreatePlayerSharedSecret", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Adds a new player statistic configuration to the title, optionally allowing the developer to specify a reset interval
        /// and an aggregation method.
        /// </summary>

        public void CreatePlayerStatisticDefinition(CreatePlayerStatisticDefinitionRequest request, Action<CreatePlayerStatisticDefinitionResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/CreatePlayerStatisticDefinition", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Delete a content file from the title. When deleting a file that does not exist, it returns success.
        /// </summary>

        public void DeleteContent(DeleteContentRequest request, Action<BlankResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/DeleteContent", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Removes a master player account entirely from all titles and deletes all associated data
        /// </summary>

        public void DeleteMasterPlayerAccount(DeleteMasterPlayerAccountRequest request, Action<DeleteMasterPlayerAccountResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/DeleteMasterPlayerAccount", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Removes a relationship between a title and an OpenID Connect provider.
        /// </summary>

        public void DeleteOpenIdConnection(DeleteOpenIdConnectionRequest request, Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/DeleteOpenIdConnection", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Removes a user's player account from a title and deletes all associated data
        /// </summary>

        public void DeletePlayer(DeletePlayerRequest request, Action<DeletePlayerResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/DeletePlayer", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Deletes an existing Player Shared Secret Key. It may take up to 5 minutes for this delete to be reflected after this API
        /// returns.
        /// </summary>

        public void DeletePlayerSharedSecret(DeletePlayerSharedSecretRequest request, Action<DeletePlayerSharedSecretResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/DeletePlayerSharedSecret", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Deletes an existing virtual item store
        /// </summary>

        public void DeleteStore(DeleteStoreRequest request, Action<DeleteStoreResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/DeleteStore", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Delete a task.
        /// </summary>

        public void DeleteTask(DeleteTaskRequest request, Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/DeleteTask", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Permanently deletes a title and all associated configuration
        /// </summary>

        public void DeleteTitle(DeleteTitleRequest request, Action<DeleteTitleResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/DeleteTitle", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Exports all associated data of a master player account
        /// </summary>

        public void ExportMasterPlayerData(ExportMasterPlayerDataRequest request, Action<ExportMasterPlayerDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/ExportMasterPlayerData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Get information about a ActionsOnPlayersInSegment task instance.
        /// </summary>

        public void GetActionsOnPlayersInSegmentTaskInstance(GetTaskInstanceRequest request, Action<GetActionsOnPlayersInSegmentTaskInstanceResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetActionsOnPlayersInSegmentTaskInstance", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves an array of player segment definitions. Results from this can be used in subsequent API calls such as
        /// GetPlayersInSegment which requires a Segment ID. While segment names can change the ID for that segment will not change.
        /// </summary>

        public void GetAllSegments(GetAllSegmentsRequest request, Action<GetAllSegmentsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetAllSegments", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the specified version of the title's catalog of virtual goods, including all defined properties
        /// </summary>

        public void GetCatalogItems(GetCatalogItemsRequest request, Action<GetCatalogItemsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetCatalogItems", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Gets the contents and information of a specific Cloud Script revision.
        /// </summary>

        public void GetCloudScriptRevision(GetCloudScriptRevisionRequest request, Action<GetCloudScriptRevisionResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetCloudScriptRevision", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Get detail information about a CloudScript task instance.
        /// </summary>

        public void GetCloudScriptTaskInstance(GetTaskInstanceRequest request, Action<GetCloudScriptTaskInstanceResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetCloudScriptTaskInstance", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Lists all the current cloud script versions. For each version, information about the current published and latest
        /// revisions is also listed.
        /// </summary>

        public void GetCloudScriptVersions(GetCloudScriptVersionsRequest request, Action<GetCloudScriptVersionsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetCloudScriptVersions", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// List all contents of the title and get statistics such as size
        /// </summary>

        public void GetContentList(GetContentListRequest request, Action<GetContentListResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetContentList", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the pre-signed URL for uploading a content file. A subsequent HTTP PUT to the returned URL uploads the
        /// content. Also, please be aware that the Content service is specifically PlayFab's CDN offering, for which standard CDN
        /// rates apply.
        /// </summary>

        public void GetContentUploadUrl(GetContentUploadUrlRequest request, Action<GetContentUploadUrlResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetContentUploadUrl", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves a download URL for the requested report
        /// </summary>

        public void GetDataReport(GetDataReportRequest request, Action<GetDataReportResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetDataReport", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the details for a specific completed session, including links to standard out and standard error logs
        /// </summary>

        public void GetMatchmakerGameInfo(GetMatchmakerGameInfoRequest request, Action<GetMatchmakerGameInfoResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetMatchmakerGameInfo", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the details of defined game modes for the specified game server executable
        /// </summary>

        public void GetMatchmakerGameModes(GetMatchmakerGameModesRequest request, Action<GetMatchmakerGameModesResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetMatchmakerGameModes", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Get the list of titles that the player has played
        /// </summary>

        public void GetPlayedTitleList(GetPlayedTitleListRequest request, Action<GetPlayedTitleListResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetPlayedTitleList", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Gets a player's ID from an auth token.
        /// </summary>

        public void GetPlayerIdFromAuthToken(GetPlayerIdFromAuthTokenRequest request, Action<GetPlayerIdFromAuthTokenResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetPlayerIdFromAuthToken", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the player's profile
        /// </summary>

        public void GetPlayerProfile(GetPlayerProfileRequest request, Action<GetPlayerProfileResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetPlayerProfile", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// List all segments that a player currently belongs to at this moment in time.
        /// </summary>

        public void GetPlayerSegments(GetPlayersSegmentsRequest request, Action<GetPlayerSegmentsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetPlayerSegments", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Returns all Player Shared Secret Keys including disabled and expired.
        /// </summary>

        public void GetPlayerSharedSecrets(GetPlayerSharedSecretsRequest request, Action<GetPlayerSharedSecretsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetPlayerSharedSecrets", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Allows for paging through all players in a given segment. This API creates a snapshot of all player profiles that match
        /// the segment definition at the time of its creation and lives through the Total Seconds to Live, refreshing its life span
        /// on each subsequent use of the Continuation Token. Profiles that change during the course of paging will not be reflected
        /// in the results. AB Test segments are currently not supported by this operation.
        /// </summary>

        public void GetPlayersInSegment(GetPlayersInSegmentRequest request, Action<GetPlayersInSegmentResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetPlayersInSegment", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the configuration information for all player statistics defined in the title, regardless of whether they have
        /// a reset interval.
        /// </summary>

        public void GetPlayerStatisticDefinitions(GetPlayerStatisticDefinitionsRequest request, Action<GetPlayerStatisticDefinitionsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetPlayerStatisticDefinitions", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the information on the available versions of the specified statistic.
        /// </summary>

        public void GetPlayerStatisticVersions(GetPlayerStatisticVersionsRequest request, Action<GetPlayerStatisticVersionsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetPlayerStatisticVersions", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Get all tags with a given Namespace (optional) from a player profile.
        /// </summary>

        public void GetPlayerTags(GetPlayerTagsRequest request, Action<GetPlayerTagsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetPlayerTags", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Gets the requested policy.
        /// </summary>

        public void GetPolicy(GetPolicyRequest request, Action<GetPolicyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetPolicy", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the key-value store of custom publisher settings
        /// </summary>

        public void GetPublisherData(GetPublisherDataRequest request, Action<GetPublisherDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetPublisherData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the random drop table configuration for the title
        /// </summary>

        public void GetRandomResultTables(GetRandomResultTablesRequest request, Action<GetRandomResultTablesResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetRandomResultTables", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the build details for the specified game server executable
        /// </summary>

        public void GetServerBuildInfo(GetServerBuildInfoRequest request, Action<GetServerBuildInfoResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetServerBuildInfo", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the pre-authorized URL for uploading a game server package containing a build (does not enable the build for
        /// use - see AddServerBuild)
        /// </summary>

        public void GetServerBuildUploadUrl(GetServerBuildUploadURLRequest request, Action<GetServerBuildUploadURLResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetServerBuildUploadUrl", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the set of items defined for the specified store, including all prices defined
        /// </summary>

        public void GetStoreItems(GetStoreItemsRequest request, Action<GetStoreItemsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetStoreItems", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Query for task instances by task, status, or time range.
        /// </summary>

        public void GetTaskInstances(GetTaskInstancesRequest request, Action<GetTaskInstancesResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetTaskInstances", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Get definition information on a specified task or all tasks within a title.
        /// </summary>

        public void GetTasks(GetTasksRequest request, Action<GetTasksResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetTasks", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the key-value store of custom title settings which can be read by the client
        /// </summary>

        public void GetTitleData(GetTitleDataRequest request, Action<GetTitleDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetTitleData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the key-value store of custom title settings which cannot be read by the client
        /// </summary>

        public void GetTitleInternalData(GetTitleDataRequest request, Action<GetTitleDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetTitleInternalData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the relevant details for a specified user, based upon a match against a supplied unique identifier
        /// </summary>

        public void GetUserAccountInfo(LookupUserAccountInfoRequest request, Action<LookupUserAccountInfoResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetUserAccountInfo", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Gets all bans for a user.
        /// </summary>

        public void GetUserBans(GetUserBansRequest request, Action<GetUserBansResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetUserBans", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the title-specific custom data for the user which is readable and writable by the client
        /// </summary>

        public void GetUserData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetUserData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the title-specific custom data for the user which cannot be accessed by the client
        /// </summary>

        public void GetUserInternalData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetUserInternalData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the specified user's current inventory of virtual goods
        /// </summary>

        public void GetUserInventory(GetUserInventoryRequest request, Action<GetUserInventoryResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetUserInventory", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the publisher-specific custom data for the user which is readable and writable by the client
        /// </summary>

        public void GetUserPublisherData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetUserPublisherData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the publisher-specific custom data for the user which cannot be accessed by the client
        /// </summary>

        public void GetUserPublisherInternalData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetUserPublisherInternalData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the publisher-specific custom data for the user which can only be read by the client
        /// </summary>

        public void GetUserPublisherReadOnlyData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetUserPublisherReadOnlyData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the title-specific custom data for the user which can only be read by the client
        /// </summary>

        public void GetUserReadOnlyData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GetUserReadOnlyData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Adds the specified items to the specified user inventories
        /// </summary>

        public void GrantItemsToUsers(GrantItemsToUsersRequest request, Action<GrantItemsToUsersResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/GrantItemsToUsers", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Increases the global count for the given scarce resource.
        /// </summary>

        public void IncrementLimitedEditionItemAvailability(IncrementLimitedEditionItemAvailabilityRequest request, Action<IncrementLimitedEditionItemAvailabilityResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/IncrementLimitedEditionItemAvailability", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Resets the indicated statistic, removing all player entries for it and backing up the old values.
        /// </summary>

        public void IncrementPlayerStatisticVersion(IncrementPlayerStatisticVersionRequest request, Action<IncrementPlayerStatisticVersionResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/IncrementPlayerStatisticVersion", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves a list of all Open ID Connect providers registered to a title.
        /// </summary>

        public void ListOpenIdConnection(ListOpenIdConnectionRequest request, Action<ListOpenIdConnectionResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/ListOpenIdConnection", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retrieves the build details for all game server executables which are currently defined for the title
        /// </summary>

        public void ListServerBuilds(ListBuildsRequest request, Action<ListBuildsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/ListServerBuilds", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Retuns the list of all defined virtual currencies for the title
        /// </summary>

        public void ListVirtualCurrencyTypes(ListVirtualCurrencyTypesRequest request, Action<ListVirtualCurrencyTypesResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/ListVirtualCurrencyTypes", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the game server mode details for the specified game server executable
        /// </summary>

        public void ModifyMatchmakerGameModes(ModifyMatchmakerGameModesRequest request, Action<ModifyMatchmakerGameModesResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/ModifyMatchmakerGameModes", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the build details for the specified game server executable
        /// </summary>

        public void ModifyServerBuild(ModifyServerBuildRequest request, Action<ModifyServerBuildResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/ModifyServerBuild", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Attempts to process an order refund through the original real money payment provider.
        /// </summary>

        public void RefundPurchase(RefundPurchaseRequest request, Action<RefundPurchaseResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/RefundPurchase", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Remove a given tag from a player profile. The tag's namespace is automatically generated based on the source of the tag.
        /// </summary>

        public void RemovePlayerTag(RemovePlayerTagRequest request, Action<RemovePlayerTagResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/RemovePlayerTag", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Removes the game server executable specified from the set of those a client is permitted to request in a call to
        /// StartGame
        /// </summary>

        public void RemoveServerBuild(RemoveServerBuildRequest request, Action<RemoveServerBuildResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/RemoveServerBuild", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Removes one or more virtual currencies from the set defined for the title.
        /// </summary>

        public void RemoveVirtualCurrencyTypes(RemoveVirtualCurrencyTypesRequest request, Action<BlankResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/RemoveVirtualCurrencyTypes", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Completely removes all statistics for the specified character, for the current game
        /// </summary>

        public void ResetCharacterStatistics(ResetCharacterStatisticsRequest request, Action<ResetCharacterStatisticsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/ResetCharacterStatistics", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Reset a player's password for a given title.
        /// </summary>

        public void ResetPassword(ResetPasswordRequest request, Action<ResetPasswordResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/ResetPassword", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Completely removes all statistics for the specified user, for the current game
        /// </summary>

        public void ResetUserStatistics(ResetUserStatisticsRequest request, Action<ResetUserStatisticsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/ResetUserStatistics", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Attempts to resolve a dispute with the original order's payment provider.
        /// </summary>

        public void ResolvePurchaseDispute(ResolvePurchaseDisputeRequest request, Action<ResolvePurchaseDisputeResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/ResolvePurchaseDispute", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Revoke all active bans for a user.
        /// </summary>

        public void RevokeAllBansForUser(RevokeAllBansForUserRequest request, Action<RevokeAllBansForUserResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/RevokeAllBansForUser", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Revoke all active bans specified with BanId.
        /// </summary>

        public void RevokeBans(RevokeBansRequest request, Action<RevokeBansResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/RevokeBans", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Revokes access to an item in a user's inventory
        /// </summary>

        public void RevokeInventoryItem(RevokeInventoryItemRequest request, Action<RevokeInventoryResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/RevokeInventoryItem", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Revokes access for up to 25 items across multiple users and characters.
        /// </summary>

        public void RevokeInventoryItems(RevokeInventoryItemsRequest request, Action<RevokeInventoryItemsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/RevokeInventoryItems", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Run a task immediately regardless of its schedule.
        /// </summary>

        public void RunTask(RunTaskRequest request, Action<RunTaskResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/RunTask", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Forces an email to be sent to the registered email address for the user's account, with a link allowing the user to
        /// change the password.If an account recovery email template ID is provided, an email using the custom email template will
        /// be used.
        /// </summary>

        public void SendAccountRecoveryEmail(SendAccountRecoveryEmailRequest request, Action<SendAccountRecoveryEmailResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/SendAccountRecoveryEmail", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Creates the catalog configuration of all virtual goods for the specified catalog version
        /// </summary>

        public void SetCatalogItems(UpdateCatalogItemsRequest request, Action<UpdateCatalogItemsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/SetCatalogItems", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Sets or resets the player's secret. Player secrets are used to sign API requests.
        /// </summary>

        public void SetPlayerSecret(SetPlayerSecretRequest request, Action<SetPlayerSecretResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/SetPlayerSecret", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Sets the currently published revision of a title Cloud Script
        /// </summary>

        public void SetPublishedRevision(SetPublishedRevisionRequest request, Action<SetPublishedRevisionResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/SetPublishedRevision", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the key-value store of custom publisher settings
        /// </summary>

        public void SetPublisherData(SetPublisherDataRequest request, Action<SetPublisherDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/SetPublisherData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Sets all the items in one virtual store
        /// </summary>

        public void SetStoreItems(UpdateStoreItemsRequest request, Action<UpdateStoreItemsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/SetStoreItems", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Creates and updates the key-value store of custom title settings which can be read by the client
        /// </summary>

        public void SetTitleData(SetTitleDataRequest request, Action<SetTitleDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/SetTitleData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the key-value store of custom title settings which cannot be read by the client
        /// </summary>

        public void SetTitleInternalData(SetTitleDataRequest request, Action<SetTitleDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/SetTitleInternalData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Sets the Amazon Resource Name (ARN) for iOS and Android push notifications. Documentation on the exact restrictions can
        /// be found at: http://docs.aws.amazon.com/sns/latest/api/API_CreatePlatformApplication.html. Currently, Amazon device
        /// Messaging is not supported.
        /// </summary>

        public void SetupPushNotification(SetupPushNotificationRequest request, Action<SetupPushNotificationResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/SetupPushNotification", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Decrements the specified virtual currency by the stated amount
        /// </summary>

        public void SubtractUserVirtualCurrency(SubtractUserVirtualCurrencyRequest request, Action<ModifyUserVirtualCurrencyResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/SubtractUserVirtualCurrency", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates information of a list of existing bans specified with Ban Ids.
        /// </summary>

        public void UpdateBans(UpdateBansRequest request, Action<UpdateBansResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateBans", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the catalog configuration for virtual goods in the specified catalog version
        /// </summary>

        public void UpdateCatalogItems(UpdateCatalogItemsRequest request, Action<UpdateCatalogItemsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateCatalogItems", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Creates a new Cloud Script revision and uploads source code to it. Note that at this time, only one file should be
        /// submitted in the revision.
        /// </summary>

        public void UpdateCloudScript(UpdateCloudScriptRequest request, Action<UpdateCloudScriptResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateCloudScript", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Modifies data and credentials for an existing relationship between a title and an Open ID Connect provider
        /// </summary>

        public void UpdateOpenIdConnection(UpdateOpenIdConnectionRequest request, Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateOpenIdConnection", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates a existing Player Shared Secret Key. It may take up to 5 minutes for this update to become generally available
        /// after this API returns.
        /// </summary>

        public void UpdatePlayerSharedSecret(UpdatePlayerSharedSecretRequest request, Action<UpdatePlayerSharedSecretResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdatePlayerSharedSecret", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates a player statistic configuration for the title, optionally allowing the developer to specify a reset interval.
        /// </summary>

        public void UpdatePlayerStatisticDefinition(UpdatePlayerStatisticDefinitionRequest request, Action<UpdatePlayerStatisticDefinitionResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdatePlayerStatisticDefinition", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Changes a policy for a title
        /// </summary>

        public void UpdatePolicy(UpdatePolicyRequest request, Action<UpdatePolicyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdatePolicy", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the random drop table configuration for the title
        /// </summary>

        public void UpdateRandomResultTables(UpdateRandomResultTablesRequest request, Action<UpdateRandomResultTablesResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateRandomResultTables", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates an existing virtual item store with new or modified items
        /// </summary>

        public void UpdateStoreItems(UpdateStoreItemsRequest request, Action<UpdateStoreItemsResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateStoreItems", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Update an existing task.
        /// </summary>

        public void UpdateTask(UpdateTaskRequest request, Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateTask", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the title-specific custom data for the user which is readable and writable by the client
        /// </summary>

        public void UpdateUserData(UpdateUserDataRequest request, Action<UpdateUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateUserData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the title-specific custom data for the user which cannot be accessed by the client
        /// </summary>

        public void UpdateUserInternalData(UpdateUserInternalDataRequest request, Action<UpdateUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateUserInternalData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the publisher-specific custom data for the user which is readable and writable by the client
        /// </summary>

        public void UpdateUserPublisherData(UpdateUserDataRequest request, Action<UpdateUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateUserPublisherData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the publisher-specific custom data for the user which cannot be accessed by the client
        /// </summary>

        public void UpdateUserPublisherInternalData(UpdateUserInternalDataRequest request, Action<UpdateUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateUserPublisherInternalData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the publisher-specific custom data for the user which can only be read by the client
        /// </summary>

        public void UpdateUserPublisherReadOnlyData(UpdateUserDataRequest request, Action<UpdateUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateUserPublisherReadOnlyData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the title-specific custom data for the user which can only be read by the client
        /// </summary>

        public void UpdateUserReadOnlyData(UpdateUserDataRequest request, Action<UpdateUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateUserReadOnlyData", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 
        /// <summary>
        /// Updates the title specific display name for a user
        /// </summary>

        public void UpdateUserTitleDisplayName(UpdateUserTitleDisplayNameRequest request, Action<UpdateUserTitleDisplayNameResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            PlayFabHttp.MakeApiCall("/Admin/UpdateUserTitleDisplayName", request, AuthType.DevSecretKey, resultCallback, errorCallback, customData, extraHeaders, false, authenticationContext, ApiSettings);
        } 

    }
}
#endif