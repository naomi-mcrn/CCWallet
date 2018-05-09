﻿using CCWallet.DiscordBot.Utilities.Insight;
using NBitcoin;
using System.Collections.Generic;
using System.Globalization;

namespace CCWallet.DiscordBot.Utilities
{
    public interface ICurrency : INetworkSet
    {
        string Name { get; }
        string IconUrl { get; }
        int BIP44CoinType { get; }
        int TransactionConfirms { get; }

        string FormatBalance(Money money, CultureInfo culture, bool symbol = true);
        Money CalculateFee(TransactionBuilder builder, IEnumerable<UnspentOutput.UnspentCoin> unspnets);
    }
}
