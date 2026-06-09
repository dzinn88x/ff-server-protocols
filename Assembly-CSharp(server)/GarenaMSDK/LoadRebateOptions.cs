using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BF1 RID: 11249
	[Token(Token = "0x2002BF1")]
	internal class LoadRebateOptions : SDKIAPTaskInstance
	{
		// Token: 0x0600F8D5 RID: 63701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8D5")]
		[Address(RVA = "0x224F7D4", Offset = "0x224F7D4", VA = "0x7BBCA4F7D4")]
		public LoadRebateOptions(SDKIAPTaskInfo info)
		{
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x0600F8D6 RID: 63702 RVA: 0x00047AC0 File Offset: 0x00045CC0
		[Token(Token = "0x1700121A")]
		public override SDKIAPTask Task
		{
			[Token(Token = "0x600F8D6")]
			[Address(RVA = "0x224F7DC", Offset = "0x224F7DC", VA = "0x7BBCA4F7DC", Slot = "4")]
			get
			{
				return SDKIAPTask.None;
			}
		}

		// Token: 0x0600F8D7 RID: 63703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8D7")]
		[Address(RVA = "0x224F7E4", Offset = "0x224F7E4", VA = "0x7BBCA4F7E4", Slot = "9")]
		internal override string IdentifySelf()
		{
			return null;
		}

		// Token: 0x0600F8D8 RID: 63704 RVA: 0x00047AD8 File Offset: 0x00045CD8
		[Token(Token = "0x600F8D8")]
		[Address(RVA = "0x224F860", Offset = "0x224F860", VA = "0x7BBCA4F860", Slot = "11")]
		public override bool IsDuplicateOf(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F8D9 RID: 63705 RVA: 0x00047AF0 File Offset: 0x00045CF0
		[Token(Token = "0x600F8D9")]
		[Address(RVA = "0x224F920", Offset = "0x224F920", VA = "0x7BBCA4F920", Slot = "12")]
		public override bool CanFinishWith(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F8DA RID: 63706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8DA")]
		[Address(RVA = "0x224F9DC", Offset = "0x224F9DC", VA = "0x7BBCA4F9DC", Slot = "13")]
		protected override void Start()
		{
		}

		// Token: 0x0600F8DB RID: 63707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8DB")]
		[Address(RVA = "0x224FAA4", Offset = "0x224FAA4", VA = "0x7BBCA4FAA4")]
		private void OnLoadedRebateOptions(SDKIAP.RebateOption[] rebateOptions, ErrorCode errorCode, string errorMessage)
		{
		}

		// Token: 0x0600F8DC RID: 63708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8DC")]
		[Address(RVA = "0x224FBA4", Offset = "0x224FBA4", VA = "0x7BBCA4FBA4", Slot = "14")]
		protected override void Succeed()
		{
		}

		// Token: 0x0600F8DD RID: 63709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8DD")]
		[Address(RVA = "0x224FC58", Offset = "0x224FC58", VA = "0x7BBCA4FC58", Slot = "15")]
		protected override void Fail()
		{
		}

		// Token: 0x0600F8DE RID: 63710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8DE")]
		[Address(RVA = "0x224FD0C", Offset = "0x224FD0C", VA = "0x7BBCA4FD0C", Slot = "16")]
		protected override void Destroy()
		{
		}

		// Token: 0x0600F8DF RID: 63711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8DF")]
		[Address(RVA = "0x224FD84", Offset = "0x224FD84", VA = "0x7BBCA4FD84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BC58", Offset = "0x114BC58")]
		private void <Succeed>b__10_0(LoadRebateOptions i)
		{
		}

		// Token: 0x0600F8E0 RID: 63712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8E0")]
		[Address(RVA = "0x224FE30", Offset = "0x224FE30", VA = "0x7BBCA4FE30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BC68", Offset = "0x114BC68")]
		private void <Fail>b__11_0(LoadRebateOptions i)
		{
		}

		// Token: 0x04011CAD RID: 72877
		[Token(Token = "0x4011CAD")]
		[FieldOffset(Offset = "0x28")]
		private SDKIAP.RebateOption[] _rebateOptions;

		// Token: 0x04011CAE RID: 72878
		[Token(Token = "0x4011CAE")]
		[FieldOffset(Offset = "0x30")]
		public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> OnDone;
	}
}
