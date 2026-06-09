using System;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B8B RID: 7051
	[Token(Token = "0x2001B8B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA4F4", Offset = "0x10FA4F4")]
	internal class UISPHudCSMatchInfoController : UIBaseController
	{
		// Token: 0x0600980C RID: 38924 RVA: 0x000280C8 File Offset: 0x000262C8
		[Token(Token = "0x600980C")]
		[Address(RVA = "0x1A2D1E4", Offset = "0x1A2D1E4", VA = "0x7BBC22D1E4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600980D RID: 38925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600980D")]
		[Address(RVA = "0x1A2D234", Offset = "0x1A2D234", VA = "0x7BBC22D234", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600980E RID: 38926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600980E")]
		[Address(RVA = "0x1A2D988", Offset = "0x1A2D988", VA = "0x7BBC22D988", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600980F RID: 38927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600980F")]
		[Address(RVA = "0x1A2DCF4", Offset = "0x1A2DCF4", VA = "0x7BBC22DCF4", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06009810 RID: 38928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009810")]
		[Address(RVA = "0x1A2DD2C", Offset = "0x1A2DD2C", VA = "0x7BBC22DD2C")]
		private void SetUIData()
		{
		}

		// Token: 0x06009811 RID: 38929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009811")]
		[Address(RVA = "0x1A2E0D8", Offset = "0x1A2E0D8", VA = "0x7BBC22E0D8")]
		private void Update()
		{
		}

		// Token: 0x06009812 RID: 38930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009812")]
		[Address(RVA = "0x1A2E188", Offset = "0x1A2E188", VA = "0x7BBC22E188")]
		private void UpdateCSCountdown()
		{
		}

		// Token: 0x06009813 RID: 38931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009813")]
		[Address(RVA = "0x1A2E574", Offset = "0x1A2E574", VA = "0x7BBC22E574")]
		private void UpdateBombCountdown()
		{
		}

		// Token: 0x06009814 RID: 38932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009814")]
		[Address(RVA = "0x1A2E9E4", Offset = "0x1A2E9E4", VA = "0x7BBC22E9E4")]
		protected void LateUpdate()
		{
		}

		// Token: 0x06009815 RID: 38933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009815")]
		[Address(RVA = "0x1A2EB5C", Offset = "0x1A2EB5C", VA = "0x7BBC22EB5C")]
		private void OnAddPlayer(params object[] data)
		{
		}

		// Token: 0x06009816 RID: 38934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009816")]
		[Address(RVA = "0x1A2F03C", Offset = "0x1A2F03C", VA = "0x7BBC22F03C")]
		private void OnScoreChanged(params object[] data)
		{
		}

		// Token: 0x06009817 RID: 38935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009817")]
		[Address(RVA = "0x1A2F25C", Offset = "0x1A2F25C", VA = "0x7BBC22F25C")]
		private void OnCoinChanged(params object[] data)
		{
		}

		// Token: 0x06009818 RID: 38936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009818")]
		[Address(RVA = "0x1A2F740", Offset = "0x1A2F740", VA = "0x7BBC22F740")]
		private void OnNewPhaseEnter(params object[] data)
		{
		}

		// Token: 0x06009819 RID: 38937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009819")]
		[Address(RVA = "0x1A2F9F8", Offset = "0x1A2F9F8", VA = "0x7BBC22F9F8")]
		private void OnBombPlantTimeSync(params object[] data)
		{
		}

		// Token: 0x0600981A RID: 38938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600981A")]
		[Address(RVA = "0x1A2DEA0", Offset = "0x1A2DEA0", VA = "0x7BBC22DEA0")]
		private void SetRoundInfoUI()
		{
		}

		// Token: 0x0600981B RID: 38939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600981B")]
		[Address(RVA = "0x1A2FB14", Offset = "0x1A2FB14", VA = "0x7BBC22FB14")]
		private void OnDelayHideEconomyInfo()
		{
		}

		// Token: 0x0600981C RID: 38940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600981C")]
		[Address(RVA = "0x1A2FB84", Offset = "0x1A2FB84", VA = "0x7BBC22FB84")]
		private void OnFactionChange(params object[] data)
		{
		}

		// Token: 0x0600981D RID: 38941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600981D")]
		[Address(RVA = "0x1A2FCDC", Offset = "0x1A2FCDC", VA = "0x7BBC22FCDC")]
		private void OnODFactionChange(params object[] data)
		{
		}

		// Token: 0x0600981E RID: 38942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600981E")]
		[Address(RVA = "0x1A2FDCC", Offset = "0x1A2FDCC", VA = "0x7BBC22FDCC")]
		private void On3PPreparation(params object[] data)
		{
		}

		// Token: 0x0600981F RID: 38943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600981F")]
		[Address(RVA = "0x1A302B4", Offset = "0x1A302B4", VA = "0x7BBC2302B4")]
		private void OnBombRemoved(params object[] data)
		{
		}

		// Token: 0x06009820 RID: 38944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009820")]
		[Address(RVA = "0x1A30370", Offset = "0x1A30370", VA = "0x7BBC230370")]
		public UISPHudCSMatchInfoController()
		{
		}

		// Token: 0x0400A00F RID: 40975
		[Token(Token = "0x400A00F")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudCSMatchInfoView m_View;

		// Token: 0x0400A010 RID: 40976
		[Token(Token = "0x400A010")]
		[FieldOffset(Offset = "0x60")]
		private int mSeconds;

		// Token: 0x0400A011 RID: 40977
		[Token(Token = "0x400A011")]
		[FieldOffset(Offset = "0x68")]
		private StringBuilder m_Timer;

		// Token: 0x0400A012 RID: 40978
		[Token(Token = "0x400A012")]
		[FieldOffset(Offset = "0x70")]
		private uint min;

		// Token: 0x0400A013 RID: 40979
		[Token(Token = "0x400A013")]
		[FieldOffset(Offset = "0x74")]
		private uint sec;

		// Token: 0x0400A014 RID: 40980
		[Token(Token = "0x400A014")]
		[FieldOffset(Offset = "0x78")]
		private OIzkGzi mGame;

		// Token: 0x0400A015 RID: 40981
		[Token(Token = "0x400A015")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsSetTeamBlueName;

		// Token: 0x0400A016 RID: 40982
		[Token(Token = "0x400A016")]
		[FieldOffset(Offset = "0x81")]
		private bool m_IsSetTeamRedName;

		// Token: 0x0400A017 RID: 40983
		[Token(Token = "0x400A017")]
		[FieldOffset(Offset = "0x82")]
		private bool m_IsSetTeamBlueIcon;

		// Token: 0x0400A018 RID: 40984
		[Token(Token = "0x400A018")]
		[FieldOffset(Offset = "0x83")]
		private bool m_IsSetTeamRedIcon;

		// Token: 0x0400A019 RID: 40985
		[Token(Token = "0x400A019")]
		[FieldOffset(Offset = "0x84")]
		private bool m_StartProgressing;

		// Token: 0x0400A01A RID: 40986
		[Token(Token = "0x400A01A")]
		[FieldOffset(Offset = "0x88")]
		private UIProgressBar m_RemoveBombProgressBar;

		// Token: 0x0400A01B RID: 40987
		[Token(Token = "0x400A01B")]
		[FieldOffset(Offset = "0x90")]
		private float m_StartTime;

		// Token: 0x0400A01C RID: 40988
		[Token(Token = "0x400A01C")]
		[FieldOffset(Offset = "0x94")]
		private float m_TotalTime;

		// Token: 0x0400A01D RID: 40989
		[Token(Token = "0x400A01D")]
		[FieldOffset(Offset = "0x98")]
		private uint m_BombExplodeTime;

		// Token: 0x0400A01E RID: 40990
		[Token(Token = "0x400A01E")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelMatch m_ModelMatch;
	}
}
