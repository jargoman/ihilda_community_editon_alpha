﻿using System;
using RippleLibSharp.Transactions;

namespace IhildaWallet
{
	public class Sentiment
	{
		public Sentiment ()
		{
		}

		public String Match {
			get;
			set;
		}

		public string Rating {
			get;
			set;
		}

		public SentimentRatingEnum GetEnum ()
		{
			Enum.TryParse<SentimentRatingEnum> (Rating, out SentimentRatingEnum sentiment);//.Parse (typeof (SentimentRatingEnum), args.NewText);
			return sentiment;
		}

		public string GetMarkupString ()
		{
			SentimentRatingEnum sentiment = GetEnum ();

			switch (sentiment) {
			case SentimentRatingEnum.Bearish:
			case SentimentRatingEnum.Very_Bearish:
			case SentimentRatingEnum.Trash:
				if (ProgramVariables.darkmode) {
					return "<span fgcolor=\"#FFAABB\">" + Rating + "</span>";
				} else {
					return "<span fgcolor=\"red\">" + Rating + "</span>";
				}

			case SentimentRatingEnum.Bullish:
			case SentimentRatingEnum.Very_Bullish:
			case SentimentRatingEnum.Mooning:
				if (ProgramVariables.darkmode) {
					return "<span fgcolor=\"chartreuse\">" + Rating + "</span>";
				} else {
					return "<span fgcolor=\"green\">" + Rating + "</span>";
				}
			}

			return Rating;
		}
	}


	public enum SentimentRatingEnum {
		Mooning = 6,
		Very_Bullish = 5,
		Bullish = 4,
		Neutral = 3,
		Bearish = 2,
		Very_Bearish = 1,
		Trash = 0

	}
}
