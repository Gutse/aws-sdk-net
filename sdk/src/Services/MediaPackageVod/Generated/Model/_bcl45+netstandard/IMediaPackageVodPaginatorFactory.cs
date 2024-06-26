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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// Paginators for the MediaPackageVod service
    ///</summary>
    public interface IMediaPackageVodPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAssets operation
        ///</summary>
        IListAssetsPaginator ListAssets(ListAssetsRequest request);

        /// <summary>
        /// Paginator for ListPackagingConfigurations operation
        ///</summary>
        IListPackagingConfigurationsPaginator ListPackagingConfigurations(ListPackagingConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListPackagingGroups operation
        ///</summary>
        IListPackagingGroupsPaginator ListPackagingGroups(ListPackagingGroupsRequest request);
    }
}