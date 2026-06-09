using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BF0 RID: 11248
	[Token(Token = "0x2002BF0")]
	internal class LoadIAPItems : SDKIAPTaskInstance
	{
		// Token: 0x0600F8C9 RID: 63689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8C9")]
		[Address(RVA = "0x224EDEC", Offset = "0x224EDEC", VA = "0x7BBCA4EDEC")]
		public LoadIAPItems(SDKIAPTaskInfo info)
		{
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x0600F8CA RID: 63690 RVA: 0x00047A78 File Offset: 0x00045C78
		[Token(Token = "0x17001219")]
		public override SDKIAPTask Task
		{
			[Token(Token = "0x600F8CA")]
			[Address(RVA = "0x224EDF4", Offset = "0x224EDF4", VA = "0x7BBCA4EDF4", Slot = "4")]
			get
			{
				return SDKIAPTask.None;
			}
		}

		// Token: 0x0600F8CB RID: 63691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8CB")]
		[Address(RVA = "0x224EDFC", Offset = "0x224EDFC", VA = "0x7BBCA4EDFC", Slot = "9")]
		internal override string IdentifySelf()
		{
			return null;
		}

		// Token: 0x0600F8CC RID: 63692 RVA: 0x00047A90 File Offset: 0x00045C90
		[Token(Token = "0x600F8CC")]
		[Address(RVA = "0x224F02C", Offset = "0x224F02C", VA = "0x7BBCA4F02C", Slot = "11")]
		public override bool IsDuplicateOf(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F8CD RID: 63693 RVA: 0x00047AA8 File Offset: 0x00045CA8
		[Token(Token = "0x600F8CD")]
		[Address(RVA = "0x224F0EC", Offset = "0x224F0EC", VA = "0x7BBCA4F0EC", Slot = "12")]
		public override bool CanFinishWith(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F8CE RID: 63694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8CE")]
		[Address(RVA = "0x224F1E0", Offset = "0x224F1E0", VA = "0x7BBCA4F1E0", Slot = "13")]
		protected override void Start()
		{
		}

		// Token: 0x0600F8CF RID: 63695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8CF")]
		[Address(RVA = "0x224F380", Offset = "0x224F380", VA = "0x7BBCA4F380")]
		private void OnLoadedIAPItems(SDKIAP.IAPItem[] items, ErrorCode errorCode, string errorMessage)
		{
		}

		// Token: 0x0600F8D0 RID: 63696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8D0")]
		[Address(RVA = "0x224F49C", Offset = "0x224F49C", VA = "0x7BBCA4F49C", Slot = "14")]
		protected override void Succeed()
		{
		}

		// Token: 0x0600F8D1 RID: 63697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8D1")]
		[Address(RVA = "0x224F550", Offset = "0x224F550", VA = "0x7BBCA4F550", Slot = "15")]
		protected override void Fail()
		{
		}

		// Token: 0x0600F8D2 RID: 63698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8D2")]
		[Address(RVA = "0x224F604", Offset = "0x224F604", VA = "0x7BBCA4F604", Slot = "16")]
		protected override void Destroy()
		{
		}

		// Token: 0x0600F8D3 RID: 63699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8D3")]
		[Address(RVA = "0x224F67C", Offset = "0x224F67C", VA = "0x7BBCA4F67C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BC38", Offset = "0x114BC38")]
		private void <Succeed>b__13_0(LoadIAPItems i)
		{
		}

		// Token: 0x0600F8D4 RID: 63700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8D4")]
		[Address(RVA = "0x224F728", Offset = "0x224F728", VA = "0x7BBCA4F728")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BC48", Offset = "0x114BC48")]
		private void <Fail>b__14_0(LoadIAPItems i)
		{
		}

		// Token: 0x04011CA8 RID: 72872
		[Token(Token = "0x4011CA8")]
		[FieldOffset(Offset = "0x28")]
		public bool Localized;

		// Token: 0x04011CA9 RID: 72873
		[Token(Token = "0x4011CA9")]
		[FieldOffset(Offset = "0x29")]
		public bool AllItems;

		// Token: 0x04011CAA RID: 72874
		[Token(Token = "0x4011CAA")]
		[FieldOffset(Offset = "0x30")]
		public long RebateId;

		// Token: 0x04011CAB RID: 72875
		[Token(Token = "0x4011CAB")]
		[FieldOffset(Offset = "0x38")]
		private SDKIAP.IAPItem[] _items;

		// Token: 0x04011CAC RID: 72876
		[Token(Token = "0x4011CAC")]
		[FieldOffset(Offset = "0x40")]
		public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> OnDone;
	}
}
