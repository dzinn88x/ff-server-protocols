using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A4B RID: 6731
	[Token(Token = "0x2001A4B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7E6C", Offset = "0x10F7E6C")]
	public class UIManualMapDebrisController : UIBaseController, ITipsDelegate
	{
		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06008D84 RID: 36228 RVA: 0x00025B30 File Offset: 0x00023D30
		[Token(Token = "0x170009E3")]
		public UIManualMapDebrisController.MapType MapDebrisType
		{
			[Token(Token = "0x6008D84")]
			[Address(RVA = "0x1DFF7C0", Offset = "0x1DFF7C0", VA = "0x7BBC5FF7C0")]
			get
			{
				return UIManualMapDebrisController.MapType.NONE;
			}
		}

		// Token: 0x06008D85 RID: 36229 RVA: 0x00025B48 File Offset: 0x00023D48
		[Token(Token = "0x6008D85")]
		[Address(RVA = "0x1DFFA24", Offset = "0x1DFFA24", VA = "0x7BBC5FFA24")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008D86 RID: 36230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D86")]
		[Address(RVA = "0x1DFFA74", Offset = "0x1DFFA74", VA = "0x7BBC5FFA74", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008D87 RID: 36231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D87")]
		[Address(RVA = "0x1DFFE84", Offset = "0x1DFFE84", VA = "0x7BBC5FFE84", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008D88 RID: 36232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D88")]
		[Address(RVA = "0x1DFFE8C", Offset = "0x1DFFE8C", VA = "0x7BBC5FFE8C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008D89 RID: 36233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D89")]
		[Address(RVA = "0x1DFF8D0", Offset = "0x1DFF8D0", VA = "0x7BBC5FF8D0")]
		public void SetData(UIManualMapDebrisController.MapType type, UIManualMapDebrisData data)
		{
		}

		// Token: 0x06008D8A RID: 36234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D8A")]
		[Address(RVA = "0x1DFFFAC", Offset = "0x1DFFFAC", VA = "0x7BBC5FFFAC")]
		private void ProcessData(UIManualMapDebrisData data)
		{
		}

		// Token: 0x06008D8B RID: 36235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D8B")]
		[Address(RVA = "0x1DFF7C8", Offset = "0x1DFF7C8", VA = "0x7BBC5FF7C8")]
		public void RefreshView()
		{
		}

		// Token: 0x06008D8C RID: 36236 RVA: 0x00025B60 File Offset: 0x00023D60
		[Token(Token = "0x6008D8C")]
		[Address(RVA = "0x1E00F1C", Offset = "0x1E00F1C", VA = "0x7BBC600F1C")]
		private bool CheckIsAllUnlock()
		{
			return default(bool);
		}

		// Token: 0x06008D8D RID: 36237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D8D")]
		[Address(RVA = "0x1E00FB0", Offset = "0x1E00FB0", VA = "0x7BBC600FB0")]
		private void RefreshAllUnlockView()
		{
		}

		// Token: 0x06008D8E RID: 36238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D8E")]
		[Address(RVA = "0x1E0131C", Offset = "0x1E0131C", VA = "0x7BBC60131C")]
		private void RefreshLockView()
		{
		}

		// Token: 0x06008D8F RID: 36239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D8F")]
		[Address(RVA = "0x1E02030", Offset = "0x1E02030", VA = "0x7BBC602030")]
		private void OnMapClick()
		{
		}

		// Token: 0x06008D90 RID: 36240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D90")]
		[Address(RVA = "0x1E023E4", Offset = "0x1E023E4", VA = "0x7BBC6023E4")]
		private void OnClickReward()
		{
		}

		// Token: 0x06008D91 RID: 36241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D91")]
		[Address(RVA = "0x1E02498", Offset = "0x1E02498", VA = "0x7BBC602498")]
		private void ShowRewardPreview()
		{
		}

		// Token: 0x06008D92 RID: 36242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D92")]
		[Address(RVA = "0x1E02990", Offset = "0x1E02990", VA = "0x7BBC602990")]
		private void OnGetRewardSuccess(params object[] data)
		{
		}

		// Token: 0x06008D93 RID: 36243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D93")]
		[Address(RVA = "0x1E028E4", Offset = "0x1E028E4", VA = "0x7BBC6028E4")]
		private void RequestMapReward()
		{
		}

		// Token: 0x06008D94 RID: 36244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D94")]
		[Address(RVA = "0x1E0011C", Offset = "0x1E0011C", VA = "0x7BBC60011C")]
		private void InitSign(UIManualMapDebrisController.MapType type)
		{
		}

		// Token: 0x06008D95 RID: 36245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D95")]
		[Address(RVA = "0x1E01684", Offset = "0x1E01684", VA = "0x7BBC601684")]
		private void RefreshRewardBtnView()
		{
		}

		// Token: 0x06008D96 RID: 36246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008D96")]
		[Address(RVA = "0x1E01A0C", Offset = "0x1E01A0C", VA = "0x7BBC601A0C")]
		private Texture CalMapTexture(ManualMapReward data)
		{
			return null;
		}

		// Token: 0x06008D97 RID: 36247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D97")]
		[Address(RVA = "0x1E01DBC", Offset = "0x1E01DBC", VA = "0x7BBC601DBC")]
		private void RefreshSign()
		{
		}

		// Token: 0x06008D98 RID: 36248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D98")]
		[Address(RVA = "0x1E02C78", Offset = "0x1E02C78", VA = "0x7BBC602C78", Slot = "28")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06008D99 RID: 36249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D99")]
		[Address(RVA = "0x1E02C88", Offset = "0x1E02C88", VA = "0x7BBC602C88")]
		public UIManualMapDebrisController()
		{
		}

		// Token: 0x06008D9B RID: 36251 RVA: 0x00025B78 File Offset: 0x00023D78
		[Token(Token = "0x6008D9B")]
		[Address(RVA = "0x1E02E04", Offset = "0x1E02E04", VA = "0x7BBC602E04")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144550", Offset = "0x1144550")]
		private bool <ProcessData>b__18_0(ManualChallenge e)
		{
			return default(bool);
		}

		// Token: 0x06008D9C RID: 36252 RVA: 0x00025B90 File Offset: 0x00023D90
		[Token(Token = "0x6008D9C")]
		[Address(RVA = "0x1E02E40", Offset = "0x1E02E40", VA = "0x7BBC602E40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144560", Offset = "0x1144560")]
		private bool <ProcessData>b__18_1(ManualMapReward e)
		{
			return default(bool);
		}

		// Token: 0x06008D9D RID: 36253 RVA: 0x00025BA8 File Offset: 0x00023DA8
		[Token(Token = "0x6008D9D")]
		[Address(RVA = "0x1E02E7C", Offset = "0x1E02E7C", VA = "0x7BBC602E7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144570", Offset = "0x1144570")]
		private bool <ProcessData>b__18_2(ManualMapData e)
		{
			return default(bool);
		}

		// Token: 0x06008D9E RID: 36254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D9E")]
		[Address(RVA = "0x1E02EB8", Offset = "0x1E02EB8", VA = "0x7BBC602EB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144580", Offset = "0x1144580")]
		private void <OnGetRewardSuccess>b__26_1()
		{
		}

		// Token: 0x06008D9F RID: 36255 RVA: 0x00025BC0 File Offset: 0x00023DC0
		[Token(Token = "0x6008D9F")]
		[Address(RVA = "0x1E02F1C", Offset = "0x1E02F1C", VA = "0x7BBC602F1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144590", Offset = "0x1144590")]
		private bool <RefreshRewardBtnView>b__29_0(ManualMapReward e)
		{
			return default(bool);
		}

		// Token: 0x04009980 RID: 39296
		[Token(Token = "0x4009980")]
		[FieldOffset(Offset = "0x58")]
		private UIManualMapDebrisController.MapType m_Type;

		// Token: 0x04009981 RID: 39297
		[Token(Token = "0x4009981")]
		[FieldOffset(Offset = "0x60")]
		private UIManualMapDebrisView m_View;

		// Token: 0x04009982 RID: 39298
		[Token(Token = "0x4009982")]
		[FieldOffset(Offset = "0x68")]
		private List<ManualChallenge> m_Desc;

		// Token: 0x04009983 RID: 39299
		[Token(Token = "0x4009983")]
		[FieldOffset(Offset = "0x70")]
		private List<ManualMapReward> m_MapRewardDataList;

		// Token: 0x04009984 RID: 39300
		[Token(Token = "0x4009984")]
		[FieldOffset(Offset = "0x78")]
		private List<ManualMapData> m_UnlockMapDataList;

		// Token: 0x04009985 RID: 39301
		[Token(Token = "0x4009985")]
		[FieldOffset(Offset = "0x80")]
		private List<UISprite> m_SignList;

		// Token: 0x04009986 RID: 39302
		[Token(Token = "0x4009986")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int m_MaxCircleCnt;

		// Token: 0x04009987 RID: 39303
		[Token(Token = "0x4009987")]
		[FieldOffset(Offset = "0x88")]
		private uint[] m_RadiusArray;

		// Token: 0x04009988 RID: 39304
		[Token(Token = "0x4009988")]
		[FieldOffset(Offset = "0x90")]
		private bool m_MapHasProcessed;

		// Token: 0x04009989 RID: 39305
		[Token(Token = "0x4009989")]
		[FieldOffset(Offset = "0x98")]
		private UIScrollView m_LabelScrollView;

		// Token: 0x02001A4C RID: 6732
		[Token(Token = "0x2001A4C")]
		public enum MapType
		{
			// Token: 0x0400998B RID: 39307
			[Token(Token = "0x400998B")]
			NONE,
			// Token: 0x0400998C RID: 39308
			[Token(Token = "0x400998C")]
			Bermuda = 1001,
			// Token: 0x0400998D RID: 39309
			[Token(Token = "0x400998D")]
			Sonoran = 4001,
			// Token: 0x0400998E RID: 39310
			[Token(Token = "0x400998E")]
			Paradise = 3001
		}

		// Token: 0x02001A4D RID: 6733
		[Token(Token = "0x2001A4D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7EA4", Offset = "0x10F7EA4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008DA1 RID: 36257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008DA1")]
			[Address(RVA = "0x1E02FBC", Offset = "0x1E02FBC", VA = "0x7BBC602FBC")]
			public <>c()
			{
			}

			// Token: 0x06008DA2 RID: 36258 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008DA2")]
			[Address(RVA = "0x1E02FC4", Offset = "0x1E02FC4", VA = "0x7BBC602FC4")]
			internal CommonRewardItemInfo <OnGetRewardSuccess>b__26_0(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0400998F RID: 39311
			[Token(Token = "0x400998F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIManualMapDebrisController.<>c <>9;

			// Token: 0x04009990 RID: 39312
			[Token(Token = "0x4009990")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__26_0;
		}
	}
}
