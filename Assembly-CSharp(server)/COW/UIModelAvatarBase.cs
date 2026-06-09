using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001D62 RID: 7522
	[Token(Token = "0x2001D62")]
	public class UIModelAvatarBase : UIBaseModel
	{
		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x0600A407 RID: 41991 RVA: 0x0002B728 File Offset: 0x00029928
		[Token(Token = "0x17000AD9")]
		public static Color FemaleStartColor
		{
			[Token(Token = "0x600A407")]
			[Address(RVA = "0x235A8F0", Offset = "0x235A8F0", VA = "0x7BBCB5A8F0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600A408 RID: 41992 RVA: 0x0002B740 File Offset: 0x00029940
		[Token(Token = "0x17000ADA")]
		public static Color AvatarStartColor
		{
			[Token(Token = "0x600A408")]
			[Address(RVA = "0x235AA5C", Offset = "0x235AA5C", VA = "0x7BBCB5AA5C")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600A409 RID: 41993 RVA: 0x0002B758 File Offset: 0x00029958
		[Token(Token = "0x17000ADB")]
		public static Color AvatarEndColor
		{
			[Token(Token = "0x600A409")]
			[Address(RVA = "0x235ABCC", Offset = "0x235ABCC", VA = "0x7BBCB5ABCC")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x0600A40A RID: 41994 RVA: 0x0002B770 File Offset: 0x00029970
		[Token(Token = "0x600A40A")]
		[Address(RVA = "0x235AD3C", Offset = "0x235AD3C", VA = "0x7BBCB5AD3C")]
		public static Color GetSkinColor(float v)
		{
			return default(Color);
		}

		// Token: 0x0600A40B RID: 41995 RVA: 0x0002B788 File Offset: 0x00029988
		[Token(Token = "0x600A40B")]
		[Address(RVA = "0x235AE00", Offset = "0x235AE00", VA = "0x7BBCB5AE00")]
		public static Color GetFemaleSkinColor(float v)
		{
			return default(Color);
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A40C")]
		[Address(RVA = "0x235AF60", Offset = "0x235AF60", VA = "0x7BBCB5AF60")]
		public static Dictionary<UIModelAvatarBase.EWardrobeType, string> AvatarSlotDict()
		{
			return null;
		}

		// Token: 0x0600A40D RID: 41997 RVA: 0x0002B7A0 File Offset: 0x000299A0
		[Token(Token = "0x600A40D")]
		[Address(RVA = "0x23562B4", Offset = "0x23562B4", VA = "0x7BBCB562B4")]
		public static bool IsFemale(uint avatar_id)
		{
			return default(bool);
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x0002B7B8 File Offset: 0x000299B8
		[Token(Token = "0x600A40E")]
		[Address(RVA = "0x235AFC8", Offset = "0x235AFC8", VA = "0x7BBCB5AFC8")]
		public static UIModelAvatarBase.EHairType GetHairType(uint avatar_id)
		{
			return UIModelAvatarBase.EHairType.HAIRTYPENONE;
		}

		// Token: 0x0600A40F RID: 41999 RVA: 0x0002B7D0 File Offset: 0x000299D0
		[Token(Token = "0x600A40F")]
		[Address(RVA = "0x2358A60", Offset = "0x2358A60", VA = "0x7BBCB58A60")]
		public static bool IsDefaultClothesID(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600A410 RID: 42000 RVA: 0x0002B7E8 File Offset: 0x000299E8
		[Token(Token = "0x600A410")]
		[Address(RVA = "0x235B05C", Offset = "0x235B05C", VA = "0x7BBCB5B05C")]
		public static uint GetDefaultClothesID(UIModelAvatarBase.EWardrobeType slot)
		{
			return 0U;
		}

		// Token: 0x0600A411 RID: 42001 RVA: 0x0002B800 File Offset: 0x00029A00
		[Token(Token = "0x600A411")]
		[Address(RVA = "0x235B098", Offset = "0x235B098", VA = "0x7BBCB5B098", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A412 RID: 42002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A412")]
		[Address(RVA = "0x235A03C", Offset = "0x235A03C", VA = "0x7BBCB5A03C")]
		public UIModelAvatarBase()
		{
		}

		// Token: 0x0400AA11 RID: 43537
		[Token(Token = "0x400AA11")]
		public const uint PropID_AvatarClothRetOK = 2U;

		// Token: 0x0400AA12 RID: 43538
		[Token(Token = "0x400AA12")]
		public const uint PropID_AvatarSkinRetOK = 4U;

		// Token: 0x0400AA13 RID: 43539
		[Token(Token = "0x400AA13")]
		public const uint PropID_AvatarBagpack = 8U;

		// Token: 0x0400AA14 RID: 43540
		[Token(Token = "0x400AA14")]
		[FieldOffset(Offset = "0x0")]
		private static Color _FemaleStartColor;

		// Token: 0x0400AA15 RID: 43541
		[Token(Token = "0x400AA15")]
		[FieldOffset(Offset = "0x10")]
		private static Color _AvatarStartColor;

		// Token: 0x0400AA16 RID: 43542
		[Token(Token = "0x400AA16")]
		[FieldOffset(Offset = "0x20")]
		private static Color _AvatarEndColor;

		// Token: 0x0400AA17 RID: 43543
		[Token(Token = "0x400AA17")]
		public const string DefaultInGameRaceFemale = "BaseFemale";

		// Token: 0x0400AA18 RID: 43544
		[Token(Token = "0x400AA18")]
		public const string DefaultInGameRaceMale = "BaseMale";

		// Token: 0x0400AA19 RID: 43545
		[Token(Token = "0x400AA19")]
		public const string HQInGameRaceFemale = "BaseFemale_N";

		// Token: 0x0400AA1A RID: 43546
		[Token(Token = "0x400AA1A")]
		public const string HQInGameRaceMale = "BaseMale_N";

		// Token: 0x0400AA1B RID: 43547
		[Token(Token = "0x400AA1B")]
		public const string ClothesFaceSlotName = "Face";

		// Token: 0x0400AA1C RID: 43548
		[Token(Token = "0x400AA1C")]
		public const string ClothesHairSlotName = "Hair";

		// Token: 0x0400AA1D RID: 43549
		[Token(Token = "0x400AA1D")]
		public const string ClothesSetSlotName = "Set";

		// Token: 0x0400AA1E RID: 43550
		[Token(Token = "0x400AA1E")]
		public const string ClothesBagPackSlotName = "BagPack";

		// Token: 0x0400AA1F RID: 43551
		[Token(Token = "0x400AA1F")]
		public const string ClothesHeadAdditiveSlotName = "HeadAdditive";

		// Token: 0x0400AA20 RID: 43552
		[Token(Token = "0x400AA20")]
		public const int ClothesSetTypeValue = 12;

		// Token: 0x0400AA21 RID: 43553
		[Token(Token = "0x400AA21")]
		public const int ClothesHairSlotValue = 11;

		// Token: 0x0400AA22 RID: 43554
		[Token(Token = "0x400AA22")]
		public const int ClothesFaceSlotValue = 8;

		// Token: 0x0400AA23 RID: 43555
		[Token(Token = "0x400AA23")]
		[FieldOffset(Offset = "0x30")]
		private static Dictionary<UIModelAvatarBase.EWardrobeType, string> m_AvatarSlotDic;

		// Token: 0x0400AA24 RID: 43556
		[Token(Token = "0x400AA24")]
		[FieldOffset(Offset = "0x38")]
		protected static Dictionary<UIModelAvatarBase.EGenderType, string> m_RaceDic;

		// Token: 0x0400AA25 RID: 43557
		[Token(Token = "0x400AA25")]
		[FieldOffset(Offset = "0x40")]
		protected static Dictionary<UIModelAvatarBase.EGenderType, string> m_RaceDicLow;

		// Token: 0x0400AA26 RID: 43558
		[Token(Token = "0x400AA26")]
		public const uint DEFAULT_HAIR_ID = 211000000U;

		// Token: 0x0400AA27 RID: 43559
		[Token(Token = "0x400AA27")]
		public const uint DEFAULT_FACE_ID = 208000000U;

		// Token: 0x0400AA28 RID: 43560
		[Token(Token = "0x400AA28")]
		public const uint DEFAULT_HEAD_ADDITIVE_ID = 214000000U;

		// Token: 0x02001D63 RID: 7523
		[Token(Token = "0x2001D63")]
		public enum EWardrobeType
		{
			// Token: 0x0400AA2A RID: 43562
			[Token(Token = "0x400AA2A")]
			CLOTHESTYPENONE,
			// Token: 0x0400AA2B RID: 43563
			[Token(Token = "0x400AA2B")]
			Head,
			// Token: 0x0400AA2C RID: 43564
			[Token(Token = "0x400AA2C")]
			Hands,
			// Token: 0x0400AA2D RID: 43565
			[Token(Token = "0x400AA2D")]
			Chest,
			// Token: 0x0400AA2E RID: 43566
			[Token(Token = "0x400AA2E")]
			Legs,
			// Token: 0x0400AA2F RID: 43567
			[Token(Token = "0x400AA2F")]
			Feet,
			// Token: 0x0400AA30 RID: 43568
			[Token(Token = "0x400AA30")]
			Waist,
			// Token: 0x0400AA31 RID: 43569
			[Token(Token = "0x400AA31")]
			Eye,
			// Token: 0x0400AA32 RID: 43570
			[Token(Token = "0x400AA32")]
			Face,
			// Token: 0x0400AA33 RID: 43571
			[Token(Token = "0x400AA33")]
			Parachute,
			// Token: 0x0400AA34 RID: 43572
			[Token(Token = "0x400AA34")]
			ParachuteBag,
			// Token: 0x0400AA35 RID: 43573
			[Token(Token = "0x400AA35")]
			Hair,
			// Token: 0x0400AA36 RID: 43574
			[Token(Token = "0x400AA36")]
			Set,
			// Token: 0x0400AA37 RID: 43575
			[Token(Token = "0x400AA37")]
			BagPack,
			// Token: 0x0400AA38 RID: 43576
			[Token(Token = "0x400AA38")]
			HeadAdditive,
			// Token: 0x0400AA39 RID: 43577
			[Token(Token = "0x400AA39")]
			EventTrigger = 20,
			// Token: 0x0400AA3A RID: 43578
			[Token(Token = "0x400AA3A")]
			All
		}

		// Token: 0x02001D64 RID: 7524
		[Token(Token = "0x2001D64")]
		public enum EGenderType
		{
			// Token: 0x0400AA3C RID: 43580
			[Token(Token = "0x400AA3C")]
			GENDERTYPENONE,
			// Token: 0x0400AA3D RID: 43581
			[Token(Token = "0x400AA3D")]
			Woman,
			// Token: 0x0400AA3E RID: 43582
			[Token(Token = "0x400AA3E")]
			Man
		}

		// Token: 0x02001D65 RID: 7525
		[Token(Token = "0x2001D65")]
		public enum EHairType
		{
			// Token: 0x0400AA40 RID: 43584
			[Token(Token = "0x400AA40")]
			HAIRTYPENONE,
			// Token: 0x0400AA41 RID: 43585
			[Token(Token = "0x400AA41")]
			SINGLEHAIR,
			// Token: 0x0400AA42 RID: 43586
			[Token(Token = "0x400AA42")]
			DOUBLEHAIR
		}

		// Token: 0x02001D66 RID: 7526
		[Token(Token = "0x2001D66")]
		public enum EClothGenderType
		{
			// Token: 0x0400AA44 RID: 43588
			[Token(Token = "0x400AA44")]
			GENDERTYPENONE,
			// Token: 0x0400AA45 RID: 43589
			[Token(Token = "0x400AA45")]
			Woman,
			// Token: 0x0400AA46 RID: 43590
			[Token(Token = "0x400AA46")]
			Man,
			// Token: 0x0400AA47 RID: 43591
			[Token(Token = "0x400AA47")]
			Common
		}

		// Token: 0x02001D67 RID: 7527
		[Token(Token = "0x2001D67")]
		[Serializable]
		public class AvatarSkin
		{
			// Token: 0x0600A414 RID: 42004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A414")]
			[Address(RVA = "0x235B57C", Offset = "0x235B57C", VA = "0x7BBCB5B57C")]
			public AvatarSkin()
			{
			}

			// Token: 0x0400AA48 RID: 43592
			[Token(Token = "0x400AA48")]
			[FieldOffset(Offset = "0x10")]
			public Color color;

			// Token: 0x0400AA49 RID: 43593
			[Token(Token = "0x400AA49")]
			[FieldOffset(Offset = "0x20")]
			public float colorNormalized;

			// Token: 0x0400AA4A RID: 43594
			[Token(Token = "0x400AA4A")]
			[FieldOffset(Offset = "0x24")]
			public uint avatar_id;

			// Token: 0x0400AA4B RID: 43595
			[Token(Token = "0x400AA4B")]
			[FieldOffset(Offset = "0x28")]
			public uint skin_color;
		}

		// Token: 0x02001D68 RID: 7528
		[Token(Token = "0x2001D68")]
		[Serializable]
		public class AvatarCloth
		{
			// Token: 0x0600A415 RID: 42005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A415")]
			[Address(RVA = "0x235B574", Offset = "0x235B574", VA = "0x7BBCB5B574")]
			public AvatarCloth()
			{
			}

			// Token: 0x0400AA4C RID: 43596
			[Token(Token = "0x400AA4C")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, uint> ClothDict;
		}

		// Token: 0x02001D69 RID: 7529
		[Token(Token = "0x2001D69")]
		public class AvatarData
		{
			// Token: 0x0600A416 RID: 42006 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A416")]
			[Address(RVA = "0x23558B0", Offset = "0x23558B0", VA = "0x7BBCB558B0")]
			public static UIModelAvatarBase.AvatarData Clone(UIModelAvatarBase.AvatarData sr)
			{
				return null;
			}

			// Token: 0x0600A417 RID: 42007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A417")]
			[Address(RVA = "0x2354AFC", Offset = "0x2354AFC", VA = "0x7BBCB54AFC")]
			public AvatarData()
			{
			}

			// Token: 0x0400AA4D RID: 43597
			[Token(Token = "0x400AA4D")]
			[FieldOffset(Offset = "0x10")]
			public bool dirty;

			// Token: 0x0400AA4E RID: 43598
			[Token(Token = "0x400AA4E")]
			[FieldOffset(Offset = "0x14")]
			public uint avatarID;

			// Token: 0x0400AA4F RID: 43599
			[Token(Token = "0x400AA4F")]
			[FieldOffset(Offset = "0x18")]
			public bool isFemale;

			// Token: 0x0400AA50 RID: 43600
			[Token(Token = "0x400AA50")]
			[FieldOffset(Offset = "0x1C")]
			public uint skin_color;

			// Token: 0x0400AA51 RID: 43601
			[Token(Token = "0x400AA51")]
			[FieldOffset(Offset = "0x20")]
			public UIModelAvatarBase.EHairType hairType;

			// Token: 0x0400AA52 RID: 43602
			[Token(Token = "0x400AA52")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<int, uint> ClothDict;
		}
	}
}
