/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Paginators for the PrometheusService service
    ///</summary>
    public interface IPrometheusServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListRuleGroupsNamespaces operation
        ///</summary>
        IListRuleGroupsNamespacesPaginator ListRuleGroupsNamespaces(ListRuleGroupsNamespacesRequest request);

        /// <summary>
        /// Paginator for ListScrapers operation
        ///</summary>
        IListScrapersPaginator ListScrapers(ListScrapersRequest request);

        /// <summary>
        /// Paginator for ListWorkspaces operation
        ///</summary>
        IListWorkspacesPaginator ListWorkspaces(ListWorkspacesRequest request);
    }
}