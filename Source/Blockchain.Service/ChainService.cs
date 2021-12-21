using Blockchain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blockchain.Service
{
    public class ChainService
    {
        /// <summary>
        /// 所有區塊
        /// </summary>
        private IList<Block> blocks;

        /// <summary>
        /// 等待中的交易
        /// </summary>
        private IList<Transaction> transactions;

        /// <summary>
        /// 出塊時間
        /// </summary>
        private readonly int blockTime = 30;

        /// <summary>
        /// 每一個區塊能夠容納的交易上限
        /// </summary>
        private readonly int blockLimitation = 32;

        /// <summary>
        /// 目前難度
        /// </summary>
        private readonly int difficulty = 1;


        /// <summary>
        /// 難度調節區塊數
        /// </summary>
        private readonly int adjustDifficultyBlocks = 10;
        
        /// <summary>
        /// 挖礦獎勵
        /// </summary>
        private readonly int rewards = 10;

        public ChainService()
        {
            this.blocks = new List<Block>();
            this.transactions = new List<Transaction>();

            var block = new Block("https://github.com/AtkSeeGow/ATK_Blockchain", this.difficulty, "atkseegow", this.rewards);
            block.Hash = HashService.Compute(block);

            this.blocks.Add(block);
        }

        public void MiningBlock()
        {
            var start = DateTime.Now;

            var lastBlock = this.blocak

        }

        public int AddTransaction(string sender, string recipient, decimal amount)
        {
            throw new NotImplementedException();

            //var transaction = new Transaction()
            //{
            //    Sender = sender,
            //    Recipient = recipient,
            //    Amount = amount
            //};
            //this.pendingTransactions.Add(transaction);
            //return this.LastBlock.Index + 1;
        }
    }
}
