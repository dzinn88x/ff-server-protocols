using System;
using System.IO;
using Il2CppDummyDll;
using message;

namespace GCommon
{
	// Token: 0x02000EF7 RID: 3831
	[Token(Token = "0x2000EF7")]
	public abstract class ReplicationEntity : Entity
	{
		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060035BA RID: 13754 RVA: 0x000103C8 File Offset: 0x0000E5C8
		// (set) Token: 0x060035BB RID: 13755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B7")]
		public AAc\u007FaKz ReplicationEntityTag
		{
			[Token(Token = "0x60035BA")]
			[Address(RVA = "0x295F35C", Offset = "0x295F35C", VA = "0x7BBD15F35C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B7AC", Offset = "0x113B7AC")]
			get
			{
				return AAc\u007FaKz.EPRI_ENTITY_TAG_NONE;
			}
			[Token(Token = "0x60035BB")]
			[Address(RVA = "0x295F364", Offset = "0x295F364", VA = "0x7BBD15F364")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B7BC", Offset = "0x113B7BC")]
			set
			{
			}
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BC")]
		[Address(RVA = "0x295F36C", Offset = "0x295F36C", VA = "0x7BBD15F36C", Slot = "11")]
		protected override void OnAwake()
		{
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BD")]
		[Address(RVA = "0x295F374", Offset = "0x295F374", VA = "0x7BBD15F374", Slot = "12")]
		protected override void OnStart()
		{
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BE")]
		[Address(RVA = "0x295F4F4", Offset = "0x295F4F4", VA = "0x7BBD15F4F4", Slot = "13")]
		protected override void OnOnDestroy()
		{
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BF")]
		[Address(RVA = "0x295F3E8", Offset = "0x295F3E8", VA = "0x7BBD15F3E8")]
		public void OnReplicationBind(uint replicationID)
		{
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C0")]
		[Address(RVA = "0x295F528", Offset = "0x295F528", VA = "0x7BBD15F528")]
		public void OnSyncReplicationData(BinaryReader reader)
		{
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x000103E0 File Offset: 0x0000E5E0
		[Token(Token = "0x60035C1")]
		[Address(RVA = "0x295F570", Offset = "0x295F570", VA = "0x7BBD15F570")]
		public uint GetReplicationID()
		{
			return 0U;
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C2")]
		[Address(RVA = "0x295F4B8", Offset = "0x295F4B8", VA = "0x7BBD15F4B8")]
		private void InvokeInitialCallback()
		{
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C3")]
		[Address(RVA = "0x295F584", Offset = "0x295F584", VA = "0x7BBD15F584", Slot = "20")]
		protected virtual void OnUserDefineReplicationInfo()
		{
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C4")]
		[Address(RVA = "0x295F588", Offset = "0x295F588", VA = "0x7BBD15F588", Slot = "21")]
		protected virtual void OnPRIInitialized()
		{
		}

		// Token: 0x060035C5 RID: 13765
		[Token(Token = "0x60035C5")]
		protected abstract int GetMaxRepDataCount();

		// Token: 0x060035C6 RID: 13766
		[Token(Token = "0x60035C6")]
		protected abstract bool IsLocalEntity();

		// Token: 0x060035C7 RID: 13767
		[Token(Token = "0x60035C7")]
		protected abstract void RegisterEntity();

		// Token: 0x060035C8 RID: 13768
		[Token(Token = "0x60035C8")]
		protected abstract void UnRegisterEntity();

		// Token: 0x060035C9 RID: 13769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C9")]
		[Address(RVA = "0x295F58C", Offset = "0x295F58C", VA = "0x7BBD15F58C")]
		protected ReplicationEntity()
		{
		}

		// Token: 0x040048D4 RID: 18644
		[Token(Token = "0x40048D4")]
		[FieldOffset(Offset = "0x30")]
		protected bool m_IsPRIRecivedFirstTime;

		// Token: 0x040048D5 RID: 18645
		[Token(Token = "0x40048D5")]
		[FieldOffset(Offset = "0x38")]
		protected PRIDataPool m_PRIDataPool;

		// Token: 0x040048D6 RID: 18646
		[Token(Token = "0x40048D6")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E808", Offset = "0x112E808")]
		private AAc\u007FaKz <ReplicationEntityTag>k__BackingField;
	}
}
