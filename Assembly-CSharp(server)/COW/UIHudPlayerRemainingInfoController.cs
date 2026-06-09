using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001931 RID: 6449
	[Token(Token = "0x2001931")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5B94", Offset = "0x10F5B94")]
	internal class UIHudPlayerRemainingInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x0600826C RID: 33388 RVA: 0x000237C0 File Offset: 0x000219C0
		[Token(Token = "0x600826C")]
		[Address(RVA = "0x1D7B8D4", Offset = "0x1D7B8D4", VA = "0x7BBC57B8D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600826D RID: 33389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600826D")]
		[Address(RVA = "0x1D7B924", Offset = "0x1D7B924", VA = "0x7BBC57B924", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600826E RID: 33390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600826E")]
		[Address(RVA = "0x1D7BF04", Offset = "0x1D7BF04", VA = "0x7BBC57BF04", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600826F RID: 33391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600826F")]
		[Address(RVA = "0x1D7BAE4", Offset = "0x1D7BAE4", VA = "0x7BBC57BAE4")]
		private void HideObject()
		{
		}

		// Token: 0x06008270 RID: 33392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008270")]
		[Address(RVA = "0x1D7BC1C", Offset = "0x1D7BC1C", VA = "0x7BBC57BC1C")]
		private void ResetCntLabel()
		{
		}

		// Token: 0x06008271 RID: 33393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008271")]
		[Address(RVA = "0x1D7C044", Offset = "0x1D7C044", VA = "0x7BBC57C044")]
		public void OnHideTheUIView(params object[] param)
		{
		}

		// Token: 0x06008272 RID: 33394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008272")]
		[Address(RVA = "0x1D7C054", Offset = "0x1D7C054", VA = "0x7BBC57C054", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008273 RID: 33395 RVA: 0x000237D8 File Offset: 0x000219D8
		[Token(Token = "0x6008273")]
		[Address(RVA = "0x1D7C534", Offset = "0x1D7C534", VA = "0x7BBC57C534", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008274 RID: 33396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008274")]
		[Address(RVA = "0x1D7C5F4", Offset = "0x1D7C5F4", VA = "0x7BBC57C5F4")]
		private void OnTrainingZonePlayerCntChange(params object[] data)
		{
		}

		// Token: 0x06008275 RID: 33397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008275")]
		[Address(RVA = "0x1D7BD88", Offset = "0x1D7BD88", VA = "0x7BBC57BD88")]
		public void InitGameModeStyle()
		{
		}

		// Token: 0x06008276 RID: 33398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008276")]
		[Address(RVA = "0x1D7C804", Offset = "0x1D7C804", VA = "0x7BBC57C804")]
		public void RefreshInfoStyle(InfoStyle infoType)
		{
		}

		// Token: 0x06008277 RID: 33399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008277")]
		[Address(RVA = "0x1D7C924", Offset = "0x1D7C924", VA = "0x7BBC57C924")]
		public void SetRemainLabel(string transfer)
		{
		}

		// Token: 0x06008278 RID: 33400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008278")]
		[Address(RVA = "0x1D7C3A4", Offset = "0x1D7C3A4", VA = "0x7BBC57C3A4")]
		private void UpdateKillCnt(int cnt)
		{
		}

		// Token: 0x06008279 RID: 33401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008279")]
		[Address(RVA = "0x1D7C49C", Offset = "0x1D7C49C", VA = "0x7BBC57C49C")]
		private void UpdateKDACnt(float cnt)
		{
		}

		// Token: 0x0600827A RID: 33402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600827A")]
		[Address(RVA = "0x1D7C2A8", Offset = "0x1D7C2A8", VA = "0x7BBC57C2A8")]
		private void UpdateAliveCnt(int cnt)
		{
		}

		// Token: 0x0600827B RID: 33403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600827B")]
		[Address(RVA = "0x1D7C340", Offset = "0x1D7C340", VA = "0x7BBC57C340")]
		private void UpdateEnemyCnt(int cnt)
		{
		}

		// Token: 0x0600827C RID: 33404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600827C")]
		[Address(RVA = "0x1D7C98C", Offset = "0x1D7C98C", VA = "0x7BBC57C98C")]
		public UIHudPlayerRemainingInfoController()
		{
		}

		// Token: 0x040093B6 RID: 37814
		[Token(Token = "0x40093B6")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPlayerRemainingInfoView m_View;

		// Token: 0x040093B7 RID: 37815
		[Token(Token = "0x40093B7")]
		[FieldOffset(Offset = "0x60")]
		private UIModelMatch m_MatchModel;

		// Token: 0x040093B8 RID: 37816
		[Token(Token = "0x40093B8")]
		[FieldOffset(Offset = "0x68")]
		private bool m_ShowKda;

		// Token: 0x040093B9 RID: 37817
		[Token(Token = "0x40093B9")]
		[FieldOffset(Offset = "0x6C")]
		private InfoStyle m_InfoStyle;
	}
}
