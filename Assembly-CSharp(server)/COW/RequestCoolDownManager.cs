using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C95 RID: 7317
	[Token(Token = "0x2001C95")]
	internal class RequestCoolDownManager : SingletonModule<RequestCoolDownManager>
	{
		// Token: 0x06009FB1 RID: 40881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FB1")]
		[Address(RVA = "0x175C9E8", Offset = "0x175C9E8", VA = "0x7BBBF5C9E8", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06009FB2 RID: 40882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FB2")]
		[Address(RVA = "0x175C9EC", Offset = "0x175C9EC", VA = "0x7BBBF5C9EC", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06009FB3 RID: 40883 RVA: 0x00029BE0 File Offset: 0x00027DE0
		[Token(Token = "0x6009FB3")]
		[Address(RVA = "0x175C9F0", Offset = "0x175C9F0", VA = "0x7BBBF5C9F0")]
		public bool CheckIsNeedRequest(string requestType, float CoolDownSecounds = 1f)
		{
			return default(bool);
		}

		// Token: 0x06009FB4 RID: 40884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FB4")]
		[Address(RVA = "0x175CDAC", Offset = "0x175CDAC", VA = "0x7BBBF5CDAC")]
		public void UpdateExpiredTime(string requestType, float CoolDownSecounds = 1f)
		{
		}

		// Token: 0x06009FB5 RID: 40885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FB5")]
		[Address(RVA = "0x175CEB8", Offset = "0x175CEB8", VA = "0x7BBBF5CEB8")]
		public void ResetExpiredTime(string requestType)
		{
		}

		// Token: 0x06009FB6 RID: 40886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FB6")]
		[Address(RVA = "0x175CF64", Offset = "0x175CF64", VA = "0x7BBBF5CF64")]
		public RequestCoolDownManager()
		{
		}

		// Token: 0x0400A674 RID: 42612
		[Token(Token = "0x400A674")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, Timer> m_CoolDownTimerDictionary;
	}
}
