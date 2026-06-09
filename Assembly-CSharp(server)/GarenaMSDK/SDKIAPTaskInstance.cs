using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BEE RID: 11246
	[Token(Token = "0x2002BEE")]
	internal class SDKIAPTaskInstance
	{
		// Token: 0x0600F8AE RID: 63662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8AE")]
		[Address(RVA = "0x273A790", Offset = "0x273A790", VA = "0x7BBCF3A790")]
		public SDKIAPTaskInstance(SDKIAPTaskInfo info)
		{
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x0600F8AF RID: 63663 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F8B0 RID: 63664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001214")]
		public SDKIAPTaskInfo Info
		{
			[Token(Token = "0x600F8AF")]
			[Address(RVA = "0x273A828", Offset = "0x273A828", VA = "0x7BBCF3A828")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BBE8", Offset = "0x114BBE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F8B0")]
			[Address(RVA = "0x273A818", Offset = "0x273A818", VA = "0x7BBCF3A818")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BBF8", Offset = "0x114BBF8")]
			private set
			{
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x0600F8B1 RID: 63665 RVA: 0x000479D0 File Offset: 0x00045BD0
		[Token(Token = "0x17001215")]
		public virtual SDKIAPTask Task
		{
			[Token(Token = "0x600F8B1")]
			[Address(RVA = "0x273A830", Offset = "0x273A830", VA = "0x7BBCF3A830", Slot = "4")]
			get
			{
				return SDKIAPTask.None;
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x0600F8B2 RID: 63666 RVA: 0x000479E8 File Offset: 0x00045BE8
		// (set) Token: 0x0600F8B3 RID: 63667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001216")]
		public virtual SDKIAPTaskState TaskState
		{
			[Token(Token = "0x600F8B2")]
			[Address(RVA = "0x273A838", Offset = "0x273A838", VA = "0x7BBCF3A838", Slot = "5")]
			get
			{
				return SDKIAPTaskState.Created;
			}
			[Token(Token = "0x600F8B3")]
			[Address(RVA = "0x273A840", Offset = "0x273A840", VA = "0x7BBCF3A840", Slot = "6")]
			internal set
			{
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x0600F8B4 RID: 63668 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F8B5 RID: 63669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001217")]
		public virtual SDKIAPTaskResult Result
		{
			[Token(Token = "0x600F8B4")]
			[Address(RVA = "0x273AB88", Offset = "0x273AB88", VA = "0x7BBCF3AB88", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BC08", Offset = "0x114BC08")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F8B5")]
			[Address(RVA = "0x273AB90", Offset = "0x273AB90", VA = "0x7BBCF3AB90", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BC18", Offset = "0x114BC18")]
			protected set
			{
			}
		}

		// Token: 0x0600F8B6 RID: 63670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8B6")]
		[Address(RVA = "0x273AB98", Offset = "0x273AB98", VA = "0x7BBCF3AB98", Slot = "9")]
		internal virtual string IdentifySelf()
		{
			return null;
		}

		// Token: 0x0600F8B7 RID: 63671 RVA: 0x00047A00 File Offset: 0x00045C00
		[Token(Token = "0x600F8B7")]
		[Address(RVA = "0x273ABE8", Offset = "0x273ABE8", VA = "0x7BBCF3ABE8", Slot = "10")]
		public virtual bool IsGoodToGo()
		{
			return default(bool);
		}

		// Token: 0x0600F8B8 RID: 63672 RVA: 0x00047A18 File Offset: 0x00045C18
		[Token(Token = "0x600F8B8")]
		[Address(RVA = "0x273ABF0", Offset = "0x273ABF0", VA = "0x7BBCF3ABF0", Slot = "11")]
		public virtual bool IsDuplicateOf(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F8B9 RID: 63673 RVA: 0x00047A30 File Offset: 0x00045C30
		[Token(Token = "0x600F8B9")]
		[Address(RVA = "0x273ACCC", Offset = "0x273ACCC", VA = "0x7BBCF3ACCC", Slot = "12")]
		public virtual bool CanFinishWith(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F8BA RID: 63674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8BA")]
		[Address(RVA = "0x273A858", Offset = "0x273A858", VA = "0x7BBCF3A858")]
		private void StateChanged(SDKIAPTaskState prev, SDKIAPTaskState next)
		{
		}

		// Token: 0x0600F8BB RID: 63675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8BB")]
		[Address(RVA = "0x273ADA8", Offset = "0x273ADA8", VA = "0x7BBCF3ADA8", Slot = "13")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600F8BC RID: 63676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8BC")]
		[Address(RVA = "0x273ADAC", Offset = "0x273ADAC", VA = "0x7BBCF3ADAC", Slot = "14")]
		protected virtual void Succeed()
		{
		}

		// Token: 0x0600F8BD RID: 63677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8BD")]
		[Address(RVA = "0x273ADB0", Offset = "0x273ADB0", VA = "0x7BBCF3ADB0", Slot = "15")]
		protected virtual void Fail()
		{
		}

		// Token: 0x0600F8BE RID: 63678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8BE")]
		[Address(RVA = "0x273ADB4", Offset = "0x273ADB4", VA = "0x7BBCF3ADB4", Slot = "16")]
		protected virtual void Destroy()
		{
		}

		// Token: 0x0600F8BF RID: 63679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8BF")]
		[Address(RVA = "0x273ADB8", Offset = "0x273ADB8", VA = "0x7BBCF3ADB8", Slot = "17")]
		protected virtual void Retry()
		{
		}

		// Token: 0x04011CA3 RID: 72867
		[Token(Token = "0x4011CA3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131DA4", Offset = "0x1131DA4")]
		private SDKIAPTaskInfo <Info>k__BackingField;

		// Token: 0x04011CA4 RID: 72868
		[Token(Token = "0x4011CA4")]
		[FieldOffset(Offset = "0x18")]
		private SDKIAPTaskState m_TaskState;

		// Token: 0x04011CA5 RID: 72869
		[Token(Token = "0x4011CA5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131DB4", Offset = "0x1131DB4")]
		private SDKIAPTaskResult <Result>k__BackingField;
	}
}
