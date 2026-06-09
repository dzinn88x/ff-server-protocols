using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001689 RID: 5769
	[Token(Token = "0x2001689")]
	public class UIHudTrainingVehicleTimerController : UIBaseController
	{
		// Token: 0x060068D1 RID: 26833 RVA: 0x0001DB38 File Offset: 0x0001BD38
		[Token(Token = "0x60068D1")]
		[Address(RVA = "0x15E8F7C", Offset = "0x15E8F7C", VA = "0x7BBBDE8F7C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060068D2 RID: 26834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D2")]
		[Address(RVA = "0x15E8FCC", Offset = "0x15E8FCC", VA = "0x7BBBDE8FCC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D3")]
		[Address(RVA = "0x15E91B4", Offset = "0x15E91B4", VA = "0x7BBBDE91B4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D4")]
		[Address(RVA = "0x15E92D4", Offset = "0x15E92D4", VA = "0x7BBBDE92D4")]
		private void Update()
		{
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D5")]
		[Address(RVA = "0x15E943C", Offset = "0x15E943C", VA = "0x7BBBDE943C")]
		private void ClearLastData()
		{
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D6")]
		[Address(RVA = "0x15E9544", Offset = "0x15E9544", VA = "0x7BBBDE9544")]
		private void UpdateResult()
		{
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D7")]
		[Address(RVA = "0x15E9710", Offset = "0x15E9710", VA = "0x7BBBDE9710")]
		private void SendRankResult(uint result)
		{
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D8")]
		[Address(RVA = "0x15E9934", Offset = "0x15E9934", VA = "0x7BBBDE9934")]
		public void StartGame(bool b)
		{
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068D9")]
		[Address(RVA = "0x15E9960", Offset = "0x15E9960", VA = "0x7BBBDE9960")]
		private void OnMiniGameClose(params object[] data)
		{
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DA")]
		[Address(RVA = "0x15E99AC", Offset = "0x15E99AC", VA = "0x7BBBDE99AC")]
		private void OnGoThroughtStartPoint(params object[] data)
		{
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DB")]
		[Address(RVA = "0x15E9AB4", Offset = "0x15E9AB4", VA = "0x7BBBDE9AB4")]
		public UIHudTrainingVehicleTimerController()
		{
		}

		// Token: 0x04008579 RID: 34169
		[Token(Token = "0x4008579")]
		[FieldOffset(Offset = "0x58")]
		private SNeSSjB m_CurrentGame;

		// Token: 0x0400857A RID: 34170
		[Token(Token = "0x400857A")]
		[FieldOffset(Offset = "0x60")]
		private UIHudTrainingVehicleTimerView m_View;

		// Token: 0x0400857B RID: 34171
		[Token(Token = "0x400857B")]
		[FieldOffset(Offset = "0x68")]
		private float m_Timer;

		// Token: 0x0400857C RID: 34172
		[Token(Token = "0x400857C")]
		[FieldOffset(Offset = "0x6C")]
		private int minute;

		// Token: 0x0400857D RID: 34173
		[Token(Token = "0x400857D")]
		[FieldOffset(Offset = "0x70")]
		private int sec;

		// Token: 0x0400857E RID: 34174
		[Token(Token = "0x400857E")]
		[FieldOffset(Offset = "0x74")]
		private int miSec;

		// Token: 0x0400857F RID: 34175
		[Token(Token = "0x400857F")]
		[FieldOffset(Offset = "0x78")]
		private int history;

		// Token: 0x04008580 RID: 34176
		[Token(Token = "0x4008580")]
		[FieldOffset(Offset = "0x7C")]
		private bool play;
	}
}
