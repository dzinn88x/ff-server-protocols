using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000556 RID: 1366
	[Token(Token = "0x2000556")]
	[ProtoContract]
	public class EInventory
	{
		// Token: 0x0600233C RID: 9020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233C")]
		[Address(RVA = "0x21B9830", Offset = "0x21B9830", VA = "0x7BBC9B9830")]
		public EInventory()
		{
		}

		// Token: 0x02000557 RID: 1367
		[Token(Token = "0x2000557")]
		[ProtoContract]
		public enum ItemType
		{
			// Token: 0x04001A01 RID: 6657
			[Token(Token = "0x4001A01")]
			ItemType_NONE,
			// Token: 0x04001A02 RID: 6658
			[Token(Token = "0x4001A02")]
			ItemType_AVATAR,
			// Token: 0x04001A03 RID: 6659
			[Token(Token = "0x4001A03")]
			ItemType_CLOTHES,
			// Token: 0x04001A04 RID: 6660
			[Token(Token = "0x4001A04")]
			ItemType_LIMITEDCARD,
			// Token: 0x04001A05 RID: 6661
			[Token(Token = "0x4001A05")]
			ItemType_TREASUREBOX,
			// Token: 0x04001A06 RID: 6662
			[Token(Token = "0x4001A06")]
			ItemType_LOADOUTBOX,
			// Token: 0x04001A07 RID: 6663
			[Token(Token = "0x4001A07")]
			ItemType_ROOMCARD,
			// Token: 0x04001A08 RID: 6664
			[Token(Token = "0x4001A08")]
			ItemType_BUNDLE,
			// Token: 0x04001A09 RID: 6665
			[Token(Token = "0x4001A09")]
			ItemType_DEBRIS,
			// Token: 0x04001A0A RID: 6666
			[Token(Token = "0x4001A0A")]
			ItemType_COLLECTION,
			// Token: 0x04001A0B RID: 6667
			[Token(Token = "0x4001A0B")]
			ItemType_VIRTUAL,
			// Token: 0x04001A0C RID: 6668
			[Token(Token = "0x4001A0C")]
			ItemType_BONUSCARD,
			// Token: 0x04001A0D RID: 6669
			[Token(Token = "0x4001A0D")]
			ItemType_STICKER,
			// Token: 0x04001A0E RID: 6670
			[Token(Token = "0x4001A0E")]
			ItemType_PET,
			// Token: 0x04001A0F RID: 6671
			[Token(Token = "0x4001A0F")]
			ItemType_BATTLEFLAG,
			// Token: 0x04001A10 RID: 6672
			[Token(Token = "0x4001A10")]
			ItemType_EP_DEBRIS,
			// Token: 0x04001A11 RID: 6673
			[Token(Token = "0x4001A11")]
			ItemType_OPTIONAL_BUNDLE = 17
		}

		// Token: 0x02000558 RID: 1368
		[Token(Token = "0x2000558")]
		[ProtoContract]
		public enum ItemSubType
		{
			// Token: 0x04001A13 RID: 6675
			[Token(Token = "0x4001A13")]
			ItemSubType_NONE,
			// Token: 0x04001A14 RID: 6676
			[Token(Token = "0x4001A14")]
			ItemSubType_LOTTERYTOKEN = 2,
			// Token: 0x04001A15 RID: 6677
			[Token(Token = "0x4001A15")]
			ItemSubType_ELITEPASS,
			// Token: 0x04001A16 RID: 6678
			[Token(Token = "0x4001A16")]
			ItemSubType_VOUCHER,
			// Token: 0x04001A17 RID: 6679
			[Token(Token = "0x4001A17")]
			ItemSubType_RENAMECARD,
			// Token: 0x04001A18 RID: 6680
			[Token(Token = "0x4001A18")]
			ItemSubType_REDENVELOPE,
			// Token: 0x04001A19 RID: 6681
			[Token(Token = "0x4001A19")]
			ItemSubType_PETFOOD,
			// Token: 0x04001A1A RID: 6682
			[Token(Token = "0x4001A1A")]
			ItemSubType_PETACTION = 9,
			// Token: 0x04001A1B RID: 6683
			[Token(Token = "0x4001A1B")]
			ItemSubType_PETSKIN,
			// Token: 0x04001A1C RID: 6684
			[Token(Token = "0x4001A1C")]
			ItemSubType_REVIVETOKEN,
			// Token: 0x04001A1D RID: 6685
			[Token(Token = "0x4001A1D")]
			ItemSubType_AVATARLEVELCARD,
			// Token: 0x04001A1E RID: 6686
			[Token(Token = "0x4001A1E")]
			ItemSubType_CHIP,
			// Token: 0x04001A1F RID: 6687
			[Token(Token = "0x4001A1F")]
			ItemSubType_GUILD_TOKEN,
			// Token: 0x04001A20 RID: 6688
			[Token(Token = "0x4001A20")]
			ItemSubType_PETSKILL,
			// Token: 0x04001A21 RID: 6689
			[Token(Token = "0x4001A21")]
			ItemSubType_CRATE,
			// Token: 0x04001A22 RID: 6690
			[Token(Token = "0x4001A22")]
			ItemSubType_GENERAL_DEBRIS,
			// Token: 0x04001A23 RID: 6691
			[Token(Token = "0x4001A23")]
			ItemSubType_LIMITED_EVENT_POINTS,
			// Token: 0x04001A24 RID: 6692
			[Token(Token = "0x4001A24")]
			ItemSubType_TIME_LIMITED_LOTTERYTOKEN,
			// Token: 0x04001A25 RID: 6693
			[Token(Token = "0x4001A25")]
			ItemSubType_LIMITED_EVENT_BOUNTY_TOKEN,
			// Token: 0x04001A26 RID: 6694
			[Token(Token = "0x4001A26")]
			ItemSubType_TRAINING_TOKEN,
			// Token: 0x04001A27 RID: 6695
			[Token(Token = "0x4001A27")]
			ItemSubType_ROOMCARD_NORMAL,
			// Token: 0x04001A28 RID: 6696
			[Token(Token = "0x4001A28")]
			ItemSubType_ROOMCARD_ADVANCED,
			// Token: 0x04001A29 RID: 6697
			[Token(Token = "0x4001A29")]
			ItemSubType_ROOMCARD_WEREWOLVES
		}

		// Token: 0x02000559 RID: 1369
		[Token(Token = "0x2000559")]
		[ProtoContract]
		public enum CollectionType
		{
			// Token: 0x04001A2B RID: 6699
			[Token(Token = "0x4001A2B")]
			CollectionType_NONE,
			// Token: 0x04001A2C RID: 6700
			[Token(Token = "0x4001A2C")]
			CollectionType_BANNER,
			// Token: 0x04001A2D RID: 6701
			[Token(Token = "0x4001A2D")]
			CollectionType_HEADPIC,
			// Token: 0x04001A2E RID: 6702
			[Token(Token = "0x4001A2E")]
			CollectionType_LOOTBOX,
			// Token: 0x04001A2F RID: 6703
			[Token(Token = "0x4001A2F")]
			CollectionType_GAMEBAG,
			// Token: 0x04001A30 RID: 6704
			[Token(Token = "0x4001A30")]
			CollectionType_PARACHUTE,
			// Token: 0x04001A31 RID: 6705
			[Token(Token = "0x4001A31")]
			CollectionType_SKATE,
			// Token: 0x04001A32 RID: 6706
			[Token(Token = "0x4001A32")]
			CollectionType_WEAPON_SKIN,
			// Token: 0x04001A33 RID: 6707
			[Token(Token = "0x4001A33")]
			CollectionType_VIHICLE_SKIN,
			// Token: 0x04001A34 RID: 6708
			[Token(Token = "0x4001A34")]
			CollectionType_EMOTE,
			// Token: 0x04001A35 RID: 6709
			[Token(Token = "0x4001A35")]
			CollectionType_PIN,
			// Token: 0x04001A36 RID: 6710
			[Token(Token = "0x4001A36")]
			CollectionType_Flight
		}

		// Token: 0x0200055A RID: 1370
		[Token(Token = "0x200055A")]
		[ProtoContract]
		public enum ClothesType
		{
			// Token: 0x04001A38 RID: 6712
			[Token(Token = "0x4001A38")]
			ClothesType_NONE,
			// Token: 0x04001A39 RID: 6713
			[Token(Token = "0x4001A39")]
			ClothesType_HEAD,
			// Token: 0x04001A3A RID: 6714
			[Token(Token = "0x4001A3A")]
			ClothesType_GLOVE,
			// Token: 0x04001A3B RID: 6715
			[Token(Token = "0x4001A3B")]
			ClothesType_COAT,
			// Token: 0x04001A3C RID: 6716
			[Token(Token = "0x4001A3C")]
			ClothesType_PANTS,
			// Token: 0x04001A3D RID: 6717
			[Token(Token = "0x4001A3D")]
			ClothesType_SHOE,
			// Token: 0x04001A3E RID: 6718
			[Token(Token = "0x4001A3E")]
			ClothesType_WAIST,
			// Token: 0x04001A3F RID: 6719
			[Token(Token = "0x4001A3F")]
			ClothesType_EYE,
			// Token: 0x04001A40 RID: 6720
			[Token(Token = "0x4001A40")]
			ClothesType_FACE,
			// Token: 0x04001A41 RID: 6721
			[Token(Token = "0x4001A41")]
			ClothesType_PARACHUTE,
			// Token: 0x04001A42 RID: 6722
			[Token(Token = "0x4001A42")]
			ClothesType_PARACHUTE_BAG,
			// Token: 0x04001A43 RID: 6723
			[Token(Token = "0x4001A43")]
			ClothesType_HAIR,
			// Token: 0x04001A44 RID: 6724
			[Token(Token = "0x4001A44")]
			ClothesType_SET,
			// Token: 0x04001A45 RID: 6725
			[Token(Token = "0x4001A45")]
			ClothesType_HEAD_ADDITIVE = 14
		}

		// Token: 0x0200055B RID: 1371
		[Token(Token = "0x200055B")]
		[ProtoContract]
		public enum GenderType
		{
			// Token: 0x04001A47 RID: 6727
			[Token(Token = "0x4001A47")]
			GenderType_NONE,
			// Token: 0x04001A48 RID: 6728
			[Token(Token = "0x4001A48")]
			GenderType_WOMAN,
			// Token: 0x04001A49 RID: 6729
			[Token(Token = "0x4001A49")]
			GenderType_MAN
		}

		// Token: 0x0200055C RID: 1372
		[Token(Token = "0x200055C")]
		[ProtoContract]
		public enum AwardType
		{
			// Token: 0x04001A4B RID: 6731
			[Token(Token = "0x4001A4B")]
			AwardType_NONE,
			// Token: 0x04001A4C RID: 6732
			[Token(Token = "0x4001A4C")]
			AwardType_ITEM,
			// Token: 0x04001A4D RID: 6733
			[Token(Token = "0x4001A4D")]
			AwardType_COINS,
			// Token: 0x04001A4E RID: 6734
			[Token(Token = "0x4001A4E")]
			AwardType_GEMS,
			// Token: 0x04001A4F RID: 6735
			[Token(Token = "0x4001A4F")]
			AwardType_SKILL,
			// Token: 0x04001A50 RID: 6736
			[Token(Token = "0x4001A50")]
			AwardType_EXP,
			// Token: 0x04001A51 RID: 6737
			[Token(Token = "0x4001A51")]
			AwardType_ACTIVENESS,
			// Token: 0x04001A52 RID: 6738
			[Token(Token = "0x4001A52")]
			AwardType_ACCELERATORS
		}

		// Token: 0x0200055D RID: 1373
		[Token(Token = "0x200055D")]
		[ProtoContract]
		public enum CurrencyType
		{
			// Token: 0x04001A54 RID: 6740
			[Token(Token = "0x4001A54")]
			CurrencyType_NONE,
			// Token: 0x04001A55 RID: 6741
			[Token(Token = "0x4001A55")]
			CurrencyType_COINS,
			// Token: 0x04001A56 RID: 6742
			[Token(Token = "0x4001A56")]
			CurrencyType_GEMS
		}

		// Token: 0x0200055E RID: 1374
		[Token(Token = "0x200055E")]
		[ProtoContract]
		public enum LimitedCardType
		{
			// Token: 0x04001A58 RID: 6744
			[Token(Token = "0x4001A58")]
			LimitedCardType_NONE,
			// Token: 0x04001A59 RID: 6745
			[Token(Token = "0x4001A59")]
			LimitedCardType_ITEM_TIME,
			// Token: 0x04001A5A RID: 6746
			[Token(Token = "0x4001A5A")]
			LimitedCardType_ITEM_NUM,
			// Token: 0x04001A5B RID: 6747
			[Token(Token = "0x4001A5B")]
			LimitedCardType_DISCOUNT
		}

		// Token: 0x0200055F RID: 1375
		[Token(Token = "0x200055F")]
		[ProtoContract]
		public enum LoadoutType
		{
			// Token: 0x04001A5D RID: 6749
			[Token(Token = "0x4001A5D")]
			LoadoutType_NONE,
			// Token: 0x04001A5E RID: 6750
			[Token(Token = "0x4001A5E")]
			LoadoutType_OLD,
			// Token: 0x04001A5F RID: 6751
			[Token(Token = "0x4001A5F")]
			LoadoutType_NEW
		}

		// Token: 0x02000560 RID: 1376
		[Token(Token = "0x2000560")]
		[ProtoContract]
		public enum BonusCardType
		{
			// Token: 0x04001A61 RID: 6753
			[Token(Token = "0x4001A61")]
			BonusCardType_NONE,
			// Token: 0x04001A62 RID: 6754
			[Token(Token = "0x4001A62")]
			BonusCardType_GOLD,
			// Token: 0x04001A63 RID: 6755
			[Token(Token = "0x4001A63")]
			BonusCardType_EXP,
			// Token: 0x04001A64 RID: 6756
			[Token(Token = "0x4001A64")]
			BonusCardType_EPDEBRIS
		}

		// Token: 0x02000561 RID: 1377
		[Token(Token = "0x2000561")]
		[ProtoContract]
		public enum VoucherType
		{
			// Token: 0x04001A66 RID: 6758
			[Token(Token = "0x4001A66")]
			VoucherType_NONE,
			// Token: 0x04001A67 RID: 6759
			[Token(Token = "0x4001A67")]
			VoucherType_COINS,
			// Token: 0x04001A68 RID: 6760
			[Token(Token = "0x4001A68")]
			VoucherType_GEMS
		}

		// Token: 0x02000562 RID: 1378
		[Token(Token = "0x2000562")]
		[ProtoContract]
		public enum TransReason
		{
			// Token: 0x04001A6A RID: 6762
			[Token(Token = "0x4001A6A")]
			TransReason_NONE,
			// Token: 0x04001A6B RID: 6763
			[Token(Token = "0x4001A6B")]
			TransReason_USECARD,
			// Token: 0x04001A6C RID: 6764
			[Token(Token = "0x4001A6C")]
			TransReason_PURCHASE,
			// Token: 0x04001A6D RID: 6765
			[Token(Token = "0x4001A6D")]
			TransReason_TREASUREBOX,
			// Token: 0x04001A6E RID: 6766
			[Token(Token = "0x4001A6E")]
			TransReason_LOADOUT,
			// Token: 0x04001A6F RID: 6767
			[Token(Token = "0x4001A6F")]
			TransReason_MATCH,
			// Token: 0x04001A70 RID: 6768
			[Token(Token = "0x4001A70")]
			TransReason_CBT_GIFTS,
			// Token: 0x04001A71 RID: 6769
			[Token(Token = "0x4001A71")]
			TransReason_ATTENDANCE,
			// Token: 0x04001A72 RID: 6770
			[Token(Token = "0x4001A72")]
			TransReason_NEWPLAYERSIGNIN,
			// Token: 0x04001A73 RID: 6771
			[Token(Token = "0x4001A73")]
			TransReason_ACTIVITY,
			// Token: 0x04001A74 RID: 6772
			[Token(Token = "0x4001A74")]
			TransReason_LEVEL_REWARD,
			// Token: 0x04001A75 RID: 6773
			[Token(Token = "0x4001A75")]
			TransReason_MAIL_ATTACHMENT,
			// Token: 0x04001A76 RID: 6774
			[Token(Token = "0x4001A76")]
			TransReason_TOPUP,
			// Token: 0x04001A77 RID: 6775
			[Token(Token = "0x4001A77")]
			TransReason_CLAN,
			// Token: 0x04001A78 RID: 6776
			[Token(Token = "0x4001A78")]
			TransReason_ADMIN,
			// Token: 0x04001A79 RID: 6777
			[Token(Token = "0x4001A79")]
			TransReason_BUNDLE,
			// Token: 0x04001A7A RID: 6778
			[Token(Token = "0x4001A7A")]
			TransReason_EXTERNAL_CALL,
			// Token: 0x04001A7B RID: 6779
			[Token(Token = "0x4001A7B")]
			TransReason_UNLOCK_PROFIILE,
			// Token: 0x04001A7C RID: 6780
			[Token(Token = "0x4001A7C")]
			TransReason_UNLOCK_PROFIILE_REWARD,
			// Token: 0x04001A7D RID: 6781
			[Token(Token = "0x4001A7D")]
			TransReason_RENAME,
			// Token: 0x04001A7E RID: 6782
			[Token(Token = "0x4001A7E")]
			TransReason_REISSUE,
			// Token: 0x04001A7F RID: 6783
			[Token(Token = "0x4001A7F")]
			TransReason_RANK_REWARD,
			// Token: 0x04001A80 RID: 6784
			[Token(Token = "0x4001A80")]
			TransReason_SEASON_REWARD,
			// Token: 0x04001A81 RID: 6785
			[Token(Token = "0x4001A81")]
			TransReason_EPPURCHASE,
			// Token: 0x04001A82 RID: 6786
			[Token(Token = "0x4001A82")]
			TransReason_EPUNLOCK,
			// Token: 0x04001A83 RID: 6787
			[Token(Token = "0x4001A83")]
			TransReason_EPPURCHASE_BADGE,
			// Token: 0x04001A84 RID: 6788
			[Token(Token = "0x4001A84")]
			TransReason_EPCHALLENGE,
			// Token: 0x04001A85 RID: 6789
			[Token(Token = "0x4001A85")]
			TransReason_LOTTERY,
			// Token: 0x04001A86 RID: 6790
			[Token(Token = "0x4001A86")]
			TransReason_LOTTERY_EXTRA_REWARD,
			// Token: 0x04001A87 RID: 6791
			[Token(Token = "0x4001A87")]
			TransReason_UNLOCK_SKILL_SLOT,
			// Token: 0x04001A88 RID: 6792
			[Token(Token = "0x4001A88")]
			TransReason_SEND_GIFT,
			// Token: 0x04001A89 RID: 6793
			[Token(Token = "0x4001A89")]
			TransReason_EPPURCHASE_BUNDLE,
			// Token: 0x04001A8A RID: 6794
			[Token(Token = "0x4001A8A")]
			TransReason_EXCHANGESTORE_PURCHASE,
			// Token: 0x04001A8B RID: 6795
			[Token(Token = "0x4001A8B")]
			TransReason_CARD,
			// Token: 0x04001A8C RID: 6796
			[Token(Token = "0x4001A8C")]
			TransReason_IAPPURCHASE,
			// Token: 0x04001A8D RID: 6797
			[Token(Token = "0x4001A8D")]
			TransReason_VETERAN_RETURN,
			// Token: 0x04001A8E RID: 6798
			[Token(Token = "0x4001A8E")]
			TransReason_ROOMCARD,
			// Token: 0x04001A8F RID: 6799
			[Token(Token = "0x4001A8F")]
			TransReason_CLAN_SIGN_IN,
			// Token: 0x04001A90 RID: 6800
			[Token(Token = "0x4001A90")]
			TransReason_EPPREORDER,
			// Token: 0x04001A91 RID: 6801
			[Token(Token = "0x4001A91")]
			TransReason_CLAN_RACE_UNLOCK,
			// Token: 0x04001A92 RID: 6802
			[Token(Token = "0x4001A92")]
			TransReason_CLAN_RACE_ALL_MEMBER,
			// Token: 0x04001A93 RID: 6803
			[Token(Token = "0x4001A93")]
			TransReason_GIFT_RANK_REWARD,
			// Token: 0x04001A94 RID: 6804
			[Token(Token = "0x4001A94")]
			TransReason_LOTTERY_SPECIAL_EXCHANGE,
			// Token: 0x04001A95 RID: 6805
			[Token(Token = "0x4001A95")]
			TransReason_CHAT_ITEMS,
			// Token: 0x04001A96 RID: 6806
			[Token(Token = "0x4001A96")]
			TransReason_PET_RENAME,
			// Token: 0x04001A97 RID: 6807
			[Token(Token = "0x4001A97")]
			TransReason_FEED_PET,
			// Token: 0x04001A98 RID: 6808
			[Token(Token = "0x4001A98")]
			TransReason_PVE_CARD,
			// Token: 0x04001A99 RID: 6809
			[Token(Token = "0x4001A99")]
			TransReason_DISCOUNTSTORE_PURCHASE,
			// Token: 0x04001A9A RID: 6810
			[Token(Token = "0x4001A9A")]
			TransReason_PET_LEVEL_UP,
			// Token: 0x04001A9B RID: 6811
			[Token(Token = "0x4001A9B")]
			TransReason_PAY_BUNDLE_WINDOW_PURCHASE,
			// Token: 0x04001A9C RID: 6812
			[Token(Token = "0x4001A9C")]
			TransReason_FESTIVAL_ATTENDANCE,
			// Token: 0x04001A9D RID: 6813
			[Token(Token = "0x4001A9D")]
			TransReason_AVATAR_LEVEL_CARD,
			// Token: 0x04001A9E RID: 6814
			[Token(Token = "0x4001A9E")]
			TransReason_FINISH_BINGO_ACTIVITY,
			// Token: 0x04001A9F RID: 6815
			[Token(Token = "0x4001A9F")]
			TransReason_BINGO_ACTIVITY_REWARDS,
			// Token: 0x04001AA0 RID: 6816
			[Token(Token = "0x4001AA0")]
			TransReason_CLAN_LUCKY_BAG,
			// Token: 0x04001AA1 RID: 6817
			[Token(Token = "0x4001AA1")]
			TransReason_EPSUBSCRIPTION,
			// Token: 0x04001AA2 RID: 6818
			[Token(Token = "0x4001AA2")]
			TransReason_REBATESUBSCRIPTION,
			// Token: 0x04001AA3 RID: 6819
			[Token(Token = "0x4001AA3")]
			TransReason_MANUAL_WEAPON,
			// Token: 0x04001AA4 RID: 6820
			[Token(Token = "0x4001AA4")]
			TransReason_MANUAL_MAP,
			// Token: 0x04001AA5 RID: 6821
			[Token(Token = "0x4001AA5")]
			TransReason_MYSTERY_BONUS,
			// Token: 0x04001AA6 RID: 6822
			[Token(Token = "0x4001AA6")]
			TransReason_INSTALLMENT_PURCHASE,
			// Token: 0x04001AA7 RID: 6823
			[Token(Token = "0x4001AA7")]
			TransReason_LOTTERY_DROPUP_BUFF,
			// Token: 0x04001AA8 RID: 6824
			[Token(Token = "0x4001AA8")]
			TransReason_BOX_REWARD,
			// Token: 0x04001AA9 RID: 6825
			[Token(Token = "0x4001AA9")]
			TransReason_FRESH_ACTIVITY,
			// Token: 0x04001AAA RID: 6826
			[Token(Token = "0x4001AAA")]
			TransReason_INSTALLMENT_MODIFY_ITEMS,
			// Token: 0x04001AAB RID: 6827
			[Token(Token = "0x4001AAB")]
			TransReason_LINKAGE_ACTIVITY,
			// Token: 0x04001AAC RID: 6828
			[Token(Token = "0x4001AAC")]
			TransReason_SWAP_ACCOUNTS,
			// Token: 0x04001AAD RID: 6829
			[Token(Token = "0x4001AAD")]
			TransReason_SUBSCRIPTION_BONUS,
			// Token: 0x04001AAE RID: 6830
			[Token(Token = "0x4001AAE")]
			TransReason_SUBSCRIPTION,
			// Token: 0x04001AAF RID: 6831
			[Token(Token = "0x4001AAF")]
			TransReason_EPTREASUREBOX,
			// Token: 0x04001AB0 RID: 6832
			[Token(Token = "0x4001AB0")]
			TransReason_VETERAN_TASK,
			// Token: 0x04001AB1 RID: 6833
			[Token(Token = "0x4001AB1")]
			TransReason_OFFER_PURCHASE,
			// Token: 0x04001AB2 RID: 6834
			[Token(Token = "0x4001AB2")]
			TransReason_PROFILE_AWAKEN_TASK_REWARDS,
			// Token: 0x04001AB3 RID: 6835
			[Token(Token = "0x4001AB3")]
			TransReason_NEW_PALAYER_LEVEL_UP_TASK,
			// Token: 0x04001AB4 RID: 6836
			[Token(Token = "0x4001AB4")]
			TransReason_TRANSFORM_GENERAL_DEBRIS,
			// Token: 0x04001AB5 RID: 6837
			[Token(Token = "0x4001AB5")]
			TransReason_CS_RANK_REWARD,
			// Token: 0x04001AB6 RID: 6838
			[Token(Token = "0x4001AB6")]
			TransReason_EP_DEBRIS,
			// Token: 0x04001AB7 RID: 6839
			[Token(Token = "0x4001AB7")]
			TransReason_CC_LIVE_REWARDS,
			// Token: 0x04001AB8 RID: 6840
			[Token(Token = "0x4001AB8")]
			TransReason_CC_GUESS_REWARDS,
			// Token: 0x04001AB9 RID: 6841
			[Token(Token = "0x4001AB9")]
			TransReason_CC_SUPPORT_REWARDS,
			// Token: 0x04001ABA RID: 6842
			[Token(Token = "0x4001ABA")]
			TransReason_CC_SUPPORT_PRIX,
			// Token: 0x04001ABB RID: 6843
			[Token(Token = "0x4001ABB")]
			TransReason_LIMITED_EVENT_STORE_PURCHASE,
			// Token: 0x04001ABC RID: 6844
			[Token(Token = "0x4001ABC")]
			TransReason_LIMITED_EVENT_CLAIM_NODE_REWARD,
			// Token: 0x04001ABD RID: 6845
			[Token(Token = "0x4001ABD")]
			TransReason_MYSTERY_STORE_PURCHASE,
			// Token: 0x04001ABE RID: 6846
			[Token(Token = "0x4001ABE")]
			TransReason_MYSTERY_STORE_UNLOCK_POOL,
			// Token: 0x04001ABF RID: 6847
			[Token(Token = "0x4001ABF")]
			TransReason_DISPATCH_QUEST_REWARD,
			// Token: 0x04001AC0 RID: 6848
			[Token(Token = "0x4001AC0")]
			TransReason_LIMITED_EVENT_ACCELERATE_CASHPRINTER,
			// Token: 0x04001AC1 RID: 6849
			[Token(Token = "0x4001AC1")]
			TransReason_PAYLEVELREWARD,
			// Token: 0x04001AC2 RID: 6850
			[Token(Token = "0x4001AC2")]
			TransReason_LIMITED_EVENT_MONEY_HEIST_HELP,
			// Token: 0x04001AC3 RID: 6851
			[Token(Token = "0x4001AC3")]
			TransReason_LIMITED_EVENT_MONEY_HEIST_REWARDS,
			// Token: 0x04001AC4 RID: 6852
			[Token(Token = "0x4001AC4")]
			TransReason_PETREISSUE,
			// Token: 0x04001AC5 RID: 6853
			[Token(Token = "0x4001AC5")]
			TransReason_ROLE_DEBRIS_PURCHASE,
			// Token: 0x04001AC6 RID: 6854
			[Token(Token = "0x4001AC6")]
			TransReason_UPGRADE_WEAPON_SKIN,
			// Token: 0x04001AC7 RID: 6855
			[Token(Token = "0x4001AC7")]
			TransReason_LIMITED_EVENT_BOOYAH_DAY_SIGN,
			// Token: 0x04001AC8 RID: 6856
			[Token(Token = "0x4001AC8")]
			TransReason_MINI_GAME,
			// Token: 0x04001AC9 RID: 6857
			[Token(Token = "0x4001AC9")]
			TransReason_LIMITED_EVENT_BOOYAH_DAY_PROCESS,
			// Token: 0x04001ACA RID: 6858
			[Token(Token = "0x4001ACA")]
			TransReason_LIMITED_EVENT_BERMUDA_PROGRESS,
			// Token: 0x04001ACB RID: 6859
			[Token(Token = "0x4001ACB")]
			TransReason_EP_WEEKLY_PROCESS_REWARDS,
			// Token: 0x04001ACC RID: 6860
			[Token(Token = "0x4001ACC")]
			TransReason_COMPLETION_GACHA_BACKPACK,
			// Token: 0x04001ACD RID: 6861
			[Token(Token = "0x4001ACD")]
			TransReason_LIMITED_EVENT_MVP_PROCESS,
			// Token: 0x04001ACE RID: 6862
			[Token(Token = "0x4001ACE")]
			TransReason_LIMITED_EVENT_GOLIATH_REWARD,
			// Token: 0x04001ACF RID: 6863
			[Token(Token = "0x4001ACF")]
			TransReason_INTIMACY_RANK_AWARD,
			// Token: 0x04001AD0 RID: 6864
			[Token(Token = "0x4001AD0")]
			TransReason_INTIMACY_CREATE_SPECIAL_RELATION,
			// Token: 0x04001AD1 RID: 6865
			[Token(Token = "0x4001AD1")]
			TransReason_LIMITED_EVENT_SUPERFIGHTER_CONSUME,
			// Token: 0x04001AD2 RID: 6866
			[Token(Token = "0x4001AD2")]
			TransReason_LIMITED_EVENT_SUPERFIGHTER_REWARD,
			// Token: 0x04001AD3 RID: 6867
			[Token(Token = "0x4001AD3")]
			TransReason_LIMITED_EVENT_SUPERCAR,
			// Token: 0x04001AD4 RID: 6868
			[Token(Token = "0x4001AD4")]
			TransReason_LIMITED_EVENT_FFWS,
			// Token: 0x04001AD5 RID: 6869
			[Token(Token = "0x4001AD5")]
			TransReason_OPTIONAL_BUNDLE,
			// Token: 0x04001AD6 RID: 6870
			[Token(Token = "0x4001AD6")]
			TransReason_AVATAR_AWAKEN_COMIC,
			// Token: 0x04001AD7 RID: 6871
			[Token(Token = "0x4001AD7")]
			TransReason_GET_AWAKEN_AVATAR,
			// Token: 0x04001AD8 RID: 6872
			[Token(Token = "0x4001AD8")]
			TransReason_REFRESH_AWAKEN_TASK
		}

		// Token: 0x02000563 RID: 1379
		[Token(Token = "0x2000563")]
		[ProtoContract]
		public enum DeleteReason
		{
			// Token: 0x04001ADA RID: 6874
			[Token(Token = "0x4001ADA")]
			DeleteReason_NONE,
			// Token: 0x04001ADB RID: 6875
			[Token(Token = "0x4001ADB")]
			DeleteReason_ZERO_CNT,
			// Token: 0x04001ADC RID: 6876
			[Token(Token = "0x4001ADC")]
			DeleteReason_OUT_EXPIRE,
			// Token: 0x04001ADD RID: 6877
			[Token(Token = "0x4001ADD")]
			DeleteReason_NO_ITEM_ID
		}

		// Token: 0x02000564 RID: 1380
		[Token(Token = "0x2000564")]
		[ProtoContract]
		public enum ClanTransSubReason
		{
			// Token: 0x04001ADF RID: 6879
			[Token(Token = "0x4001ADF")]
			ClanTransSubReason_NONE,
			// Token: 0x04001AE0 RID: 6880
			[Token(Token = "0x4001AE0")]
			ClanTransSubReason_CREATE,
			// Token: 0x04001AE1 RID: 6881
			[Token(Token = "0x4001AE1")]
			ClanTransSubReason_EXPAND,
			// Token: 0x04001AE2 RID: 6882
			[Token(Token = "0x4001AE2")]
			ClanTransSubReason_CLAN_RENAME
		}

		// Token: 0x02000565 RID: 1381
		[Token(Token = "0x2000565")]
		[ProtoContract]
		public enum ItemStatus
		{
			// Token: 0x04001AE4 RID: 6884
			[Token(Token = "0x4001AE4")]
			ItemStatus_NONE,
			// Token: 0x04001AE5 RID: 6885
			[Token(Token = "0x4001AE5")]
			ItemStatus_PERMANENT,
			// Token: 0x04001AE6 RID: 6886
			[Token(Token = "0x4001AE6")]
			ItemStatus_INEXPIRE,
			// Token: 0x04001AE7 RID: 6887
			[Token(Token = "0x4001AE7")]
			ItemStatus_OUTEXPIRE
		}

		// Token: 0x02000566 RID: 1382
		[Token(Token = "0x2000566")]
		[ProtoContract]
		public enum InstallmentStatus
		{
			// Token: 0x04001AE9 RID: 6889
			[Token(Token = "0x4001AE9")]
			InstallmentStatus_NONE,
			// Token: 0x04001AEA RID: 6890
			[Token(Token = "0x4001AEA")]
			InstallmentStatus_INSTALLMENT,
			// Token: 0x04001AEB RID: 6891
			[Token(Token = "0x4001AEB")]
			InstallmentStatus_LOCK
		}

		// Token: 0x02000567 RID: 1383
		[Token(Token = "0x2000567")]
		[ProtoContract]
		public enum InstallmentType
		{
			// Token: 0x04001AED RID: 6893
			[Token(Token = "0x4001AED")]
			InstallmentType_NONE,
			// Token: 0x04001AEE RID: 6894
			[Token(Token = "0x4001AEE")]
			InstallmentType_WEEK,
			// Token: 0x04001AEF RID: 6895
			[Token(Token = "0x4001AEF")]
			InstallmentType_MONTH,
			// Token: 0x04001AF0 RID: 6896
			[Token(Token = "0x4001AF0")]
			InstallmentType_QUARTER
		}

		// Token: 0x02000568 RID: 1384
		[Token(Token = "0x2000568")]
		[ProtoContract]
		public enum StoreTag
		{
			// Token: 0x04001AF2 RID: 6898
			[Token(Token = "0x4001AF2")]
			StoreTag_NONE,
			// Token: 0x04001AF3 RID: 6899
			[Token(Token = "0x4001AF3")]
			StoreTag_DISCOUNT,
			// Token: 0x04001AF4 RID: 6900
			[Token(Token = "0x4001AF4")]
			StoreTag_HOT,
			// Token: 0x04001AF5 RID: 6901
			[Token(Token = "0x4001AF5")]
			StoreTag_NEW,
			// Token: 0x04001AF6 RID: 6902
			[Token(Token = "0x4001AF6")]
			StoreTag_LIMITEDTIME,
			// Token: 0x04001AF7 RID: 6903
			[Token(Token = "0x4001AF7")]
			StoreTag_PURCHASELIMITED,
			// Token: 0x04001AF8 RID: 6904
			[Token(Token = "0x4001AF8")]
			StoreTag_EARLY_ACCESS,
			// Token: 0x04001AF9 RID: 6905
			[Token(Token = "0x4001AF9")]
			StoreTag_DISPLAY_LEFTTIME
		}

		// Token: 0x02000569 RID: 1385
		[Token(Token = "0x2000569")]
		[ProtoContract]
		public enum TopupTxnType
		{
			// Token: 0x04001AFB RID: 6907
			[Token(Token = "0x4001AFB")]
			TopupTxnType_NONE,
			// Token: 0x04001AFC RID: 6908
			[Token(Token = "0x4001AFC")]
			TopupTxnType_INGAME,
			// Token: 0x04001AFD RID: 6909
			[Token(Token = "0x4001AFD")]
			TopupTxnType_MSHOP,
			// Token: 0x04001AFE RID: 6910
			[Token(Token = "0x4001AFE")]
			TopupTxnType_ADMIN,
			// Token: 0x04001AFF RID: 6911
			[Token(Token = "0x4001AFF")]
			TopupTxnType_PROMO,
			// Token: 0x04001B00 RID: 6912
			[Token(Token = "0x4001B00")]
			TopupTxnType_REBATE
		}

		// Token: 0x0200056A RID: 1386
		[Token(Token = "0x200056A")]
		[ProtoContract]
		public enum RareType
		{
			// Token: 0x04001B02 RID: 6914
			[Token(Token = "0x4001B02")]
			RareType_NONE,
			// Token: 0x04001B03 RID: 6915
			[Token(Token = "0x4001B03")]
			RareType_White,
			// Token: 0x04001B04 RID: 6916
			[Token(Token = "0x4001B04")]
			RareType_Green,
			// Token: 0x04001B05 RID: 6917
			[Token(Token = "0x4001B05")]
			RareType_Blue,
			// Token: 0x04001B06 RID: 6918
			[Token(Token = "0x4001B06")]
			RareType_Purple,
			// Token: 0x04001B07 RID: 6919
			[Token(Token = "0x4001B07")]
			RareType_Orange,
			// Token: 0x04001B08 RID: 6920
			[Token(Token = "0x4001B08")]
			RareType_Card,
			// Token: 0x04001B09 RID: 6921
			[Token(Token = "0x4001B09")]
			RareType_Red
		}

		// Token: 0x0200056B RID: 1387
		[Token(Token = "0x200056B")]
		[ProtoContract]
		public enum EPCardErrorType
		{
			// Token: 0x04001B0B RID: 6923
			[Token(Token = "0x4001B0B")]
			EPCardErrorType_NONE,
			// Token: 0x04001B0C RID: 6924
			[Token(Token = "0x4001B0C")]
			EPCardErrorType_DISABLE,
			// Token: 0x04001B0D RID: 6925
			[Token(Token = "0x4001B0D")]
			EPCardErrorType_NO_RETURN,
			// Token: 0x04001B0E RID: 6926
			[Token(Token = "0x4001B0E")]
			EPCardErrorType_ACTIVE
		}

		// Token: 0x0200056C RID: 1388
		[Token(Token = "0x200056C")]
		[ProtoContract]
		public enum StorePromotionType
		{
			// Token: 0x04001B10 RID: 6928
			[Token(Token = "0x4001B10")]
			StorePromotionType_NORMAL,
			// Token: 0x04001B11 RID: 6929
			[Token(Token = "0x4001B11")]
			StorePromotionType_DISCOUNT
		}

		// Token: 0x0200056D RID: 1389
		[Token(Token = "0x200056D")]
		[ProtoContract]
		public enum ItemSourceType
		{
			// Token: 0x04001B13 RID: 6931
			[Token(Token = "0x4001B13")]
			ItemSourceType_DEFAULT,
			// Token: 0x04001B14 RID: 6932
			[Token(Token = "0x4001B14")]
			ItemSourceType_BUNDLE,
			// Token: 0x04001B15 RID: 6933
			[Token(Token = "0x4001B15")]
			ItemSourceType_GIFTMAIL,
			// Token: 0x04001B16 RID: 6934
			[Token(Token = "0x4001B16")]
			ItemSourceType_WEBPAGE,
			// Token: 0x04001B17 RID: 6935
			[Token(Token = "0x4001B17")]
			ItemSourceType_STORE,
			// Token: 0x04001B18 RID: 6936
			[Token(Token = "0x4001B18")]
			ItemSourceType_ACTIVITY,
			// Token: 0x04001B19 RID: 6937
			[Token(Token = "0x4001B19")]
			ItemSourceType_LOTTERY,
			// Token: 0x04001B1A RID: 6938
			[Token(Token = "0x4001B1A")]
			ItemSourceType_BACKPACK,
			// Token: 0x04001B1B RID: 6939
			[Token(Token = "0x4001B1B")]
			ItemSourceType_TREASUREBOX,
			// Token: 0x04001B1C RID: 6940
			[Token(Token = "0x4001B1C")]
			ItemSourceType_FRESH_ACTIVITY,
			// Token: 0x04001B1D RID: 6941
			[Token(Token = "0x4001B1D")]
			ItemSourceType_LINKAGE_ACTIVITY,
			// Token: 0x04001B1E RID: 6942
			[Token(Token = "0x4001B1E")]
			ItemSourceType_PROFILE,
			// Token: 0x04001B1F RID: 6943
			[Token(Token = "0x4001B1F")]
			ItemSourceType_COMPETITION,
			// Token: 0x04001B20 RID: 6944
			[Token(Token = "0x4001B20")]
			ItemSourceType_MYSTERYSHOP,
			// Token: 0x04001B21 RID: 6945
			[Token(Token = "0x4001B21")]
			ItemSourceType_LIMITED_EVENT,
			// Token: 0x04001B22 RID: 6946
			[Token(Token = "0x4001B22")]
			ItemSourceType_INTIMACY,
			// Token: 0x04001B23 RID: 6947
			[Token(Token = "0x4001B23")]
			ItemSourceType_OPTIONAL_BUNDLE = 17
		}

		// Token: 0x0200056E RID: 1390
		[Token(Token = "0x200056E")]
		[ProtoContract]
		public enum MaterialItemType
		{
			// Token: 0x04001B25 RID: 6949
			[Token(Token = "0x4001B25")]
			MaterialItemType_NONE,
			// Token: 0x04001B26 RID: 6950
			[Token(Token = "0x4001B26")]
			MaterialItemType_ITEMS,
			// Token: 0x04001B27 RID: 6951
			[Token(Token = "0x4001B27")]
			MaterialItemType_COINS,
			// Token: 0x04001B28 RID: 6952
			[Token(Token = "0x4001B28")]
			MaterialItemType_GEMS
		}

		// Token: 0x0200056F RID: 1391
		[Token(Token = "0x200056F")]
		[ProtoContract]
		public enum TopupEvent
		{
			// Token: 0x04001B2A RID: 6954
			[Token(Token = "0x4001B2A")]
			TopupEvent_NONE,
			// Token: 0x04001B2B RID: 6955
			[Token(Token = "0x4001B2B")]
			TopupEvent_MYSTERY_BONUS,
			// Token: 0x04001B2C RID: 6956
			[Token(Token = "0x4001B2C")]
			TopupEvent_DIAMOND_SPEND
		}

		// Token: 0x02000570 RID: 1392
		[Token(Token = "0x2000570")]
		[ProtoContract]
		public enum MysterySwitchActivateReason
		{
			// Token: 0x04001B2E RID: 6958
			[Token(Token = "0x4001B2E")]
			MysterySwitchActivateReason_NONE,
			// Token: 0x04001B2F RID: 6959
			[Token(Token = "0x4001B2F")]
			MysterySwitchActivateReason_COSTGEMS,
			// Token: 0x04001B30 RID: 6960
			[Token(Token = "0x4001B30")]
			MysterySwitchActivateReason_PURCHASEITEM
		}

		// Token: 0x02000571 RID: 1393
		[Token(Token = "0x2000571")]
		[ProtoContract]
		public enum LegendClothCdtType
		{
			// Token: 0x04001B32 RID: 6962
			[Token(Token = "0x4001B32")]
			LegendClothCdtType_NONE,
			// Token: 0x04001B33 RID: 6963
			[Token(Token = "0x4001B33")]
			LegendClothCdtType_Rank
		}
	}
}
