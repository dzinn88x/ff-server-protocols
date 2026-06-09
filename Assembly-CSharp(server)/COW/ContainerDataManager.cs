using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011B5 RID: 4533
	[Token(Token = "0x20011B5")]
	internal class ContainerDataManager : SingletonModule<ContainerDataManager>
	{
		// Token: 0x06004685 RID: 18053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004685")]
		[Address(RVA = "0x16002F8", Offset = "0x16002F8", VA = "0x7BBBE002F8", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004686")]
		[Address(RVA = "0x1600358", Offset = "0x1600358", VA = "0x7BBBE00358", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004687 RID: 18055 RVA: 0x00015408 File Offset: 0x00013608
		[Token(Token = "0x6004687")]
		[Address(RVA = "0x160035C", Offset = "0x160035C", VA = "0x7BBBE0035C")]
		private ulong GetModeSettingKey(uint map_id, uint mode_id, bool isWaitingRoom)
		{
			return 0UL;
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004688")]
		[Address(RVA = "0x1600398", Offset = "0x1600398", VA = "0x7BBBE00398")]
		public ContainerDatas GetConatinerDatas(uint map_id, uint mode_id, bool isWaitingRoom)
		{
			return null;
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004689")]
		[Address(RVA = "0x16005E4", Offset = "0x16005E4", VA = "0x7BBBE005E4")]
		private ContainerDatas LoadDatas(ResourceID resID)
		{
			return null;
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468A")]
		[Address(RVA = "0x160067C", Offset = "0x160067C", VA = "0x7BBBE0067C")]
		public ContainerDataManager()
		{
		}

		// Token: 0x040057E4 RID: 22500
		[Token(Token = "0x40057E4")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ulong, ContainerDatas> m_ContainerDatas;
	}
}
