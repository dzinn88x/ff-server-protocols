using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C22 RID: 7202
	[Token(Token = "0x2001C22")]
	public class GameFunctionSwitchDataManager : SingletonModule<GameFunctionSwitchDataManager>
	{
		// Token: 0x06009CBF RID: 40127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CBF")]
		[Address(RVA = "0x187DDE0", Offset = "0x187DDE0", VA = "0x7BBC07DDE0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06009CC0 RID: 40128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CC0")]
		[Address(RVA = "0x187DE80", Offset = "0x187DE80", VA = "0x7BBC07DE80", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06009CC1 RID: 40129 RVA: 0x00029220 File Offset: 0x00027420
		[Token(Token = "0x6009CC1")]
		[Address(RVA = "0x187DE84", Offset = "0x187DE84", VA = "0x7BBC07DE84")]
		public bool CheckIsFunctionAvailable(FunctionType fType, bool ShowTips = false)
		{
			return default(bool);
		}

		// Token: 0x06009CC2 RID: 40130 RVA: 0x00029238 File Offset: 0x00027438
		[Token(Token = "0x6009CC2")]
		[Address(RVA = "0x187E204", Offset = "0x187E204", VA = "0x7BBC07E204")]
		public bool CheckCanShowRankGuide()
		{
			return default(bool);
		}

		// Token: 0x06009CC3 RID: 40131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CC3")]
		[Address(RVA = "0x187E38C", Offset = "0x187E38C", VA = "0x7BBC07E38C")]
		public void SetLevelLimit(FunctionType type, int levelLimit)
		{
		}

		// Token: 0x06009CC4 RID: 40132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CC4")]
		[Address(RVA = "0x187E494", Offset = "0x187E494", VA = "0x7BBC07E494")]
		public GameFunctionSwitchDataManager()
		{
		}
	}
}
