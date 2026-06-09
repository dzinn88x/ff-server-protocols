using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014F3 RID: 5363
	[Token(Token = "0x20014F3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDD44", Offset = "0x10EDD44")]
	public class UIEPDailyTaskItemController : UIEasyListItemController
	{
		// Token: 0x06005BE3 RID: 23523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE3")]
		[Address(RVA = "0x221131C", Offset = "0x221131C", VA = "0x7BBCA1131C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005BE4 RID: 23524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE4")]
		[Address(RVA = "0x221148C", Offset = "0x221148C", VA = "0x7BBCA1148C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005BE5 RID: 23525 RVA: 0x0001AD00 File Offset: 0x00018F00
		[Token(Token = "0x6005BE5")]
		[Address(RVA = "0x2211558", Offset = "0x2211558", VA = "0x7BBCA11558")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE6")]
		[Address(RVA = "0x22115A8", Offset = "0x22115A8", VA = "0x7BBCA115A8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005BE7 RID: 23527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE7")]
		[Address(RVA = "0x2211910", Offset = "0x2211910", VA = "0x7BBCA11910")]
		private string GetQuestDesc(EPDailyQuestInfo dInfo)
		{
			return null;
		}

		// Token: 0x06005BE8 RID: 23528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE8")]
		[Address(RVA = "0x22120B4", Offset = "0x22120B4", VA = "0x7BBCA120B4")]
		private void OnEPDailyTaskStateUpdate(params object[] data)
		{
		}

		// Token: 0x06005BE9 RID: 23529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE9")]
		[Address(RVA = "0x2211DF8", Offset = "0x2211DF8", VA = "0x7BBCA11DF8")]
		private void SetEffect()
		{
		}

		// Token: 0x06005BEA RID: 23530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BEA")]
		[Address(RVA = "0x2212334", Offset = "0x2212334", VA = "0x7BBCA12334")]
		public UIEPDailyTaskItemController()
		{
		}

		// Token: 0x06005BEB RID: 23531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BEB")]
		[Address(RVA = "0x221233C", Offset = "0x221233C", VA = "0x7BBCA1233C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F6FC", Offset = "0x113F6FC")]
		private void <OnEPDailyTaskStateUpdate>b__7_0()
		{
		}

		// Token: 0x06005BEC RID: 23532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BEC")]
		[Address(RVA = "0x221245C", Offset = "0x221245C", VA = "0x7BBCA1245C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F70C", Offset = "0x113F70C")]
		private void <SetEffect>b__8_0()
		{
		}

		// Token: 0x04007E41 RID: 32321
		[Token(Token = "0x4007E41")]
		[FieldOffset(Offset = "0x70")]
		private UIEPDailyTaskItemView m_View;

		// Token: 0x04007E42 RID: 32322
		[Token(Token = "0x4007E42")]
		[FieldOffset(Offset = "0x78")]
		private EPDailyQuestInfo m_Data;
	}
}
