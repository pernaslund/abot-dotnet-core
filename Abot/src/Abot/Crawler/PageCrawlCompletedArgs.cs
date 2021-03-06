﻿using Abot.Poco;
using System;

namespace Abot.Crawler
{
    
    public class PageCrawlCompletedArgs : CrawlArgs
    {
        public CrawledPage CrawledPage { get; private set; }

        public PageCrawlCompletedArgs(CrawlContext crawlContext, CrawledPage crawledPage)
            : base(crawlContext)
        {
            if (crawledPage == null)
                throw new ArgumentNullException(nameof(crawledPage));

            CrawledPage = crawledPage;
        }
    }
}
