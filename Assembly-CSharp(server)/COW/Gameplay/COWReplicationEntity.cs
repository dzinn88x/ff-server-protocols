using System;
using GCommon;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x020026E4 RID: 9956
	[Token(Token = "0x20026E4")]
	public abstract class COWReplicationEntity : ReplicationEntity
	{
		// Token: 0x0600CF6F RID: 53103 RVA: 0x00037860 File Offset: 0x00035A60
		[Token(Token = "0x600CF6F")]
		[Address(RVA = "0x17CD90C", Offset = "0x17CD90C", VA = "0x7BBBFCD90C", Slot = "23")]
		protected override bool IsLocalEntity()
		{
			return default(bool);
		}

		// Token: 0x0600CF70 RID: 53104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF70")]
		[Address(RVA = "0x17CD978", Offset = "0x17CD978", VA = "0x7BBBFCD978", Slot = "24")]
		protected override void RegisterEntity()
		{
		}

		// Token: 0x0600CF71 RID: 53105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF71")]
		[Address(RVA = "0x17CDA44", Offset = "0x17CDA44", VA = "0x7BBBFCDA44", Slot = "25")]
		protected override void UnRegisterEntity()
		{
		}

		// Token: 0x0600CF72 RID: 53106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF72")]
		[Address(RVA = "0x17CDB10", Offset = "0x17CDB10", VA = "0x7BBBFCDB10")]
		protected COWReplicationEntity()
		{
		}
	}
}
