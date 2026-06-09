using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TsiU;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F0A RID: 3850
	[Token(Token = "0x2000F0A")]
	public class LocManager : TSingleton<LocManager>
	{
		// Token: 0x06003636 RID: 13878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003636")]
		[Address(RVA = "0x21244A4", Offset = "0x21244A4", VA = "0x7BBC9244A4")]
		public string Fix(string text, bool all = false)
		{
			return null;
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003637")]
		[Address(RVA = "0x21244E0", Offset = "0x21244E0", VA = "0x7BBC9244E0")]
		public string FixArabicInOthersLang(string text, bool needReverse = true)
		{
			return null;
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003638")]
		[Address(RVA = "0x2124558", Offset = "0x2124558", VA = "0x7BBC924558")]
		public string FixArabicCustomInput(string text, bool noRegion)
		{
			return null;
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003639")]
		[Address(RVA = "0x212450C", Offset = "0x212450C", VA = "0x7BBC92450C")]
		public static string FixArabicWhenIsArabic(string text, bool needReverse)
		{
			return null;
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363A")]
		[Address(RVA = "0x21244D0", Offset = "0x21244D0", VA = "0x7BBC9244D0")]
		private static string FixArabic(string text, bool needReverse = false)
		{
			return null;
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363B")]
		[Address(RVA = "0x21245C4", Offset = "0x21245C4", VA = "0x7BBC9245C4")]
		private static string GetUnfixedLocText(UIInput input)
		{
			return null;
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363C")]
		[Address(RVA = "0x2124768", Offset = "0x2124768", VA = "0x7BBC924768")]
		public void Init(LocGlobalComponent global, LocLang currentLang)
		{
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363D")]
		[Address(RVA = "0x21248E0", Offset = "0x21248E0", VA = "0x7BBC9248E0")]
		public void RefreshCurrLang(LocLang currentLang)
		{
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363E")]
		[Address(RVA = "0x21249E4", Offset = "0x21249E4", VA = "0x7BBC9249E4")]
		public void RefreshFont(LocLang currentLang)
		{
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600363F")]
		[Address(RVA = "0x2124E3C", Offset = "0x2124E3C", VA = "0x7BBC924E3C")]
		public void AddTranslation(string translation, bool use_new = true, bool is_hotfix = false)
		{
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003640")]
		[Address(RVA = "0x21252CC", Offset = "0x21252CC", VA = "0x7BBC9252CC")]
		public void AddCurrentTranslation(string idStr, string transStr, bool needOverWrite = true)
		{
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003641")]
		[Address(RVA = "0x2125998", Offset = "0x2125998", VA = "0x7BBC925998")]
		public void AfterTranslationsAdded()
		{
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06003642 RID: 13890 RVA: 0x000107E8 File Offset: 0x0000E9E8
		[Token(Token = "0x170006BA")]
		public LocLang CurrentLanguage
		{
			[Token(Token = "0x6003642")]
			[Address(RVA = "0x2121994", Offset = "0x2121994", VA = "0x7BBC921994")]
			get
			{
				return LocLang.None;
			}
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00010800 File Offset: 0x0000EA00
		[Token(Token = "0x6003643")]
		[Address(RVA = "0x2125A68", Offset = "0x2125A68", VA = "0x7BBC925A68")]
		private bool GetRawTranslation(string stringID, out string trans)
		{
			return default(bool);
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003644")]
		[Address(RVA = "0x2125B28", Offset = "0x2125B28", VA = "0x7BBC925B28")]
		private string GetTranslationByFlagIndex(uint flagIdx)
		{
			return null;
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003645")]
		[Address(RVA = "0x2125B2C", Offset = "0x2125B2C", VA = "0x7BBC925B2C")]
		public string GetTranslationByIndex(ushort idx)
		{
			return null;
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x00010818 File Offset: 0x0000EA18
		[Token(Token = "0x6003646")]
		[Address(RVA = "0x2125BF4", Offset = "0x2125BF4", VA = "0x7BBC925BF4")]
		public ushort GetTranslationIndex(string stringID)
		{
			return 0;
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003647")]
		[Address(RVA = "0x2125C7C", Offset = "0x2125C7C", VA = "0x7BBC925C7C")]
		public Font GetDefaultFont(string fontSetName)
		{
			return null;
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003648")]
		[Address(RVA = "0x2125CFC", Offset = "0x2125CFC", VA = "0x7BBC925CFC")]
		public string[] GetTypeList()
		{
			return null;
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003649")]
		[Address(RVA = "0x2125D04", Offset = "0x2125D04", VA = "0x7BBC925D04")]
		public void DoLoc(UILabel label, string stringID, params object[] param)
		{
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364A")]
		[Address(RVA = "0x2125D48", Offset = "0x2125D48", VA = "0x7BBC925D48")]
		public void DoLocWithOptions(UILabel label, string stringID, LocManager.LocOptions locOptions, params object[] param)
		{
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364B")]
		[Address(RVA = "0x21219A4", Offset = "0x21219A4", VA = "0x7BBC9219A4")]
		public void DoLocWithOptions(UILabel label, string stringID, bool noArabic, params object[] param)
		{
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364C")]
		[Address(RVA = "0x2121A00", Offset = "0x2121A00", VA = "0x7BBC921A00")]
		public void DoLoc(UISprite sprite, string spriteID, LocManager.ImageLocalizeType type, params object[] param)
		{
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364D")]
		[Address(RVA = "0x2125DBC", Offset = "0x2125DBC", VA = "0x7BBC925DBC")]
		public string DoLoc(string stringID, Dictionary<string, string> dic, params object[] param)
		{
			return null;
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364E")]
		[Address(RVA = "0x2125EA0", Offset = "0x2125EA0", VA = "0x7BBC925EA0")]
		private string _DoLoc(string stringID, params object[] param)
		{
			return null;
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00010830 File Offset: 0x0000EA30
		[Token(Token = "0x600364F")]
		[Address(RVA = "0x2125F68", Offset = "0x2125F68", VA = "0x7BBC925F68")]
		private bool _HasLoc(string stringID)
		{
			return default(bool);
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003650")]
		[Address(RVA = "0x21231DC", Offset = "0x21231DC", VA = "0x7BBC9231DC")]
		public string DoLoc(string stringID, params object[] param)
		{
			return null;
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003651")]
		[Address(RVA = "0x2125FD8", Offset = "0x2125FD8", VA = "0x7BBC925FD8")]
		public string LocOrFix(string stringID, params object[] param)
		{
			return null;
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003652")]
		[Address(RVA = "0x2125DA0", Offset = "0x2125DA0", VA = "0x7BBC925DA0")]
		public string DoLocWithOptions(string stringID, LocManager.LocOptions options, params object[] param)
		{
			return null;
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003653")]
		[Address(RVA = "0x2124764", Offset = "0x2124764", VA = "0x7BBC924764")]
		public string DoLocOriginal(string stringID, params object[] param)
		{
			return null;
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003654")]
		[Address(RVA = "0x212604C", Offset = "0x212604C", VA = "0x7BBC92604C")]
		public void DoLocSpecifiedLanguage(UILabel label, LocLang lan, string stringID, params object[] param)
		{
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003655")]
		[Address(RVA = "0x2126344", Offset = "0x2126344", VA = "0x7BBC926344")]
		public void SetFont(UILabel label, LocLang lan)
		{
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003656")]
		[Address(RVA = "0x212620C", Offset = "0x212620C", VA = "0x7BBC92620C")]
		public Font GetFont(string fontSetName, LocLang lan)
		{
			return null;
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003657")]
		[Address(RVA = "0x212199C", Offset = "0x212199C", VA = "0x7BBC92199C")]
		public Font GetFont(string fontSetName)
		{
			return null;
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003658")]
		[Address(RVA = "0x2124E48", Offset = "0x2124E48", VA = "0x7BBC924E48")]
		private void ParseTranslation(string translation, bool use_new, bool is_hotfix = false)
		{
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003659")]
		[Address(RVA = "0x21255A8", Offset = "0x21255A8", VA = "0x7BBC9255A8")]
		private void ParseTranslation(string idStr, string transStr, bool needOverWrite = true)
		{
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365A")]
		[Address(RVA = "0x21264C0", Offset = "0x21264C0", VA = "0x7BBC9264C0")]
		private void AddTranslation(string id, string trans, LocManager.LocUseCase useCase, bool needOverWrite)
		{
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365B")]
		[Address(RVA = "0x2126664", Offset = "0x2126664", VA = "0x7BBC926664")]
		public void UnloadUselessData()
		{
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365C")]
		[Address(RVA = "0x2126998", Offset = "0x2126998", VA = "0x7BBC926998")]
		public LocManager()
		{
		}

		// Token: 0x0400497F RID: 18815
		[Token(Token = "0x400497F")]
		private const int CapacityLocText = 28000;

		// Token: 0x04004980 RID: 18816
		[Token(Token = "0x4004980")]
		[FieldOffset(Offset = "0x10")]
		private LocGlobalComponent m_LocGlobal;

		// Token: 0x04004981 RID: 18817
		[Token(Token = "0x4004981")]
		[FieldOffset(Offset = "0x18")]
		private LocLang m_CurrentLang;

		// Token: 0x04004982 RID: 18818
		[Token(Token = "0x4004982")]
		[FieldOffset(Offset = "0x20")]
		private string m_CurrentLangAbbr;

		// Token: 0x04004983 RID: 18819
		[Token(Token = "0x4004983")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, Dictionary<LocLang, LocGlobalComponent.LocFontSet.LocFont>> m_Fonts;

		// Token: 0x04004984 RID: 18820
		[Token(Token = "0x4004984")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> m_LocAtlasSprite;

		// Token: 0x04004985 RID: 18821
		[Token(Token = "0x4004985")]
		public const ushort INVALID_TRANS_INDEX = 65535;

		// Token: 0x04004986 RID: 18822
		[Token(Token = "0x4004986")]
		private const uint LocTextIdxMask = 65535U;

		// Token: 0x04004987 RID: 18823
		[Token(Token = "0x4004987")]
		private const uint LocTextFlagCleared = 2147483648U;

		// Token: 0x04004988 RID: 18824
		[Token(Token = "0x4004988")]
		private const int LocTextFlagsShift = 24;

		// Token: 0x04004989 RID: 18825
		[Token(Token = "0x4004989")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, uint> m_LocText;

		// Token: 0x0400498A RID: 18826
		[Token(Token = "0x400498A")]
		[FieldOffset(Offset = "0x40")]
		private List<string> m_LocTextTranslations;

		// Token: 0x0400498B RID: 18827
		[Token(Token = "0x400498B")]
		[FieldOffset(Offset = "0x48")]
		public bool FlagFixArabicNameInOtherLanguage;

		// Token: 0x0400498C RID: 18828
		[Token(Token = "0x400498C")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, Font> m_DefaultFont;

		// Token: 0x0400498D RID: 18829
		[Token(Token = "0x400498D")]
		[FieldOffset(Offset = "0x58")]
		private string[] m_TypeList;

		// Token: 0x0400498E RID: 18830
		[Token(Token = "0x400498E")]
		[FieldOffset(Offset = "0x60")]
		public bool HasLobbyOnlyStrings;

		// Token: 0x0400498F RID: 18831
		[Token(Token = "0x400498F")]
		[FieldOffset(Offset = "0x68")]
		public readonly LocManager.LocOptions NoArabicSupport;

		// Token: 0x02000F0B RID: 3851
		[Token(Token = "0x2000F0B")]
		public enum LocUseCase : byte
		{
			// Token: 0x04004991 RID: 18833
			[Token(Token = "0x4004991")]
			Both,
			// Token: 0x04004992 RID: 18834
			[Token(Token = "0x4004992")]
			LobbyOnly,
			// Token: 0x04004993 RID: 18835
			[Token(Token = "0x4004993")]
			IngameOnly,
			// Token: 0x04004994 RID: 18836
			[Token(Token = "0x4004994")]
			HotFix
		}

		// Token: 0x02000F0C RID: 3852
		[Token(Token = "0x2000F0C")]
		public enum ImageLocalizeType
		{
			// Token: 0x04004996 RID: 18838
			[Token(Token = "0x4004996")]
			Sprite,
			// Token: 0x04004997 RID: 18839
			[Token(Token = "0x4004997")]
			Atlas
		}

		// Token: 0x02000F0D RID: 3853
		[Token(Token = "0x2000F0D")]
		public class LocOptions
		{
			// Token: 0x0600365D RID: 13917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600365D")]
			[Address(RVA = "0x2126BF0", Offset = "0x2126BF0", VA = "0x7BBC926BF0")]
			public LocOptions()
			{
			}

			// Token: 0x04004998 RID: 18840
			[Token(Token = "0x4004998")]
			[FieldOffset(Offset = "0x10")]
			public bool NoArabic;
		}
	}
}
