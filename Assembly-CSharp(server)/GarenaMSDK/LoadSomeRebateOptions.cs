using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BF4 RID: 11252
	[Token(Token = "0x2002BF4")]
	internal class LoadSomeRebateOptions : SDKIAPTaskInstance
	{
		// Token: 0x0600F8F1 RID: 63729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F1")]
		[Address(RVA = "0x2250A28", Offset = "0x2250A28", VA = "0x7BBCA50A28")]
		public LoadSomeRebateOptions(SDKIAPTaskInfo info)
		{
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x0600F8F2 RID: 63730 RVA: 0x00047B50 File Offset: 0x00045D50
		[Token(Token = "0x1700121C")]
		public override SDKIAPTask Task
		{
			[Token(Token = "0x600F8F2")]
			[Address(RVA = "0x2250A30", Offset = "0x2250A30", VA = "0x7BBCA50A30", Slot = "4")]
			get
			{
				return SDKIAPTask.None;
			}
		}

		// Token: 0x0600F8F3 RID: 63731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8F3")]
		[Address(RVA = "0x2250A38", Offset = "0x2250A38", VA = "0x7BBCA50A38", Slot = "9")]
		internal override string IdentifySelf()
		{
			return null;
		}

		// Token: 0x0600F8F4 RID: 63732 RVA: 0x00047B68 File Offset: 0x00045D68
		[Token(Token = "0x600F8F4")]
		[Address(RVA = "0x2250BB0", Offset = "0x2250BB0", VA = "0x7BBCA50BB0", Slot = "11")]
		public override bool IsDuplicateOf(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F8F5 RID: 63733 RVA: 0x00047B80 File Offset: 0x00045D80
		[Token(Token = "0x600F8F5")]
		[Address(RVA = "0x2250C88", Offset = "0x2250C88", VA = "0x7BBCA50C88", Slot = "12")]
		public override bool CanFinishWith(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F8F6 RID: 63734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F6")]
		[Address(RVA = "0x2250C90", Offset = "0x2250C90", VA = "0x7BBCA50C90", Slot = "13")]
		protected override void Start()
		{
		}

		// Token: 0x0600F8F7 RID: 63735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F7")]
		[Address(RVA = "0x2250D6C", Offset = "0x2250D6C", VA = "0x7BBCA50D6C")]
		private void OnLoadedRebateOptions(SDKIAP.RebateOption[] rebateOptions, ErrorCode errorCode, string errorMessage)
		{
		}

		// Token: 0x0600F8F8 RID: 63736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F8")]
		[Address(RVA = "0x2250E6C", Offset = "0x2250E6C", VA = "0x7BBCA50E6C", Slot = "14")]
		protected override void Succeed()
		{
		}

		// Token: 0x0600F8F9 RID: 63737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8F9")]
		[Address(RVA = "0x2250F20", Offset = "0x2250F20", VA = "0x7BBCA50F20", Slot = "15")]
		protected override void Fail()
		{
		}

		// Token: 0x0600F8FA RID: 63738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8FA")]
		[Address(RVA = "0x2250FD4", Offset = "0x2250FD4", VA = "0x7BBCA50FD4", Slot = "16")]
		protected override void Destroy()
		{
		}

		// Token: 0x0600F8FB RID: 63739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8FB")]
		[Address(RVA = "0x225104C", Offset = "0x225104C", VA = "0x7BBCA5104C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BC98", Offset = "0x114BC98")]
		private void <Succeed>b__11_0(LoadSomeRebateOptions i)
		{
		}

		// Token: 0x0600F8FC RID: 63740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8FC")]
		[Address(RVA = "0x22510F8", Offset = "0x22510F8", VA = "0x7BBCA510F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BCA8", Offset = "0x114BCA8")]
		private void <Fail>b__12_0(LoadSomeRebateOptions i)
		{
		}

		// Token: 0x04011CB7 RID: 72887
		[Token(Token = "0x4011CB7")]
		[FieldOffset(Offset = "0x28")]
		public long[] RebateIds;

		// Token: 0x04011CB8 RID: 72888
		[Token(Token = "0x4011CB8")]
		[FieldOffset(Offset = "0x30")]
		private SDKIAP.RebateOption[] _RebateOptions;

		// Token: 0x04011CB9 RID: 72889
		[Token(Token = "0x4011CB9")]
		[FieldOffset(Offset = "0x38")]
		public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> OnDone;

		// Token: 0x02002BF5 RID: 11253
		[Token(Token = "0x2002BF5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FF7F4", Offset = "0x10FF7F4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600F8FE RID: 63742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F8FE")]
			[Address(RVA = "0x2251208", Offset = "0x2251208", VA = "0x7BBCA51208")]
			public <>c()
			{
			}

			// Token: 0x0600F8FF RID: 63743 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F8FF")]
			[Address(RVA = "0x2251210", Offset = "0x2251210", VA = "0x7BBCA51210")]
			internal string <IdentifySelf>b__6_0(long id)
			{
				return null;
			}

			// Token: 0x04011CBA RID: 72890
			[Token(Token = "0x4011CBA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LoadSomeRebateOptions.<>c <>9;

			// Token: 0x04011CBB RID: 72891
			[Token(Token = "0x4011CBB")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<long, string> <>9__6_0;
		}
	}
}
