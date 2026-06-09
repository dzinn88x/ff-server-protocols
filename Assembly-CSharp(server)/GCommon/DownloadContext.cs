using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FD7 RID: 4055
	[Token(Token = "0x2000FD7")]
	public class DownloadContext
	{
		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06003B7B RID: 15227 RVA: 0x000128D0 File Offset: 0x00010AD0
		// (set) Token: 0x06003B7C RID: 15228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F8")]
		public EDownloadContextState State
		{
			[Token(Token = "0x6003B7B")]
			[Address(RVA = "0x25F04E8", Offset = "0x25F04E8", VA = "0x7BBCDF04E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BC98", Offset = "0x113BC98")]
			get
			{
				return EDownloadContextState.None;
			}
			[Token(Token = "0x6003B7C")]
			[Address(RVA = "0x25F04F0", Offset = "0x25F04F0", VA = "0x7BBCDF04F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BCA8", Offset = "0x113BCA8")]
			protected set
			{
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06003B7D RID: 15229 RVA: 0x000128E8 File Offset: 0x00010AE8
		[Token(Token = "0x170006F9")]
		public bool IsPaused
		{
			[Token(Token = "0x6003B7D")]
			[Address(RVA = "0x25F04F8", Offset = "0x25F04F8", VA = "0x7BBCDF04F8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06003B7E RID: 15230 RVA: 0x00012900 File Offset: 0x00010B00
		[Token(Token = "0x170006FA")]
		public bool IsFinished
		{
			[Token(Token = "0x6003B7E")]
			[Address(RVA = "0x25F0508", Offset = "0x25F0508", VA = "0x7BBCDF0508")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06003B7F RID: 15231 RVA: 0x00012918 File Offset: 0x00010B18
		[Token(Token = "0x170006FB")]
		public bool IsStarted
		{
			[Token(Token = "0x6003B7F")]
			[Address(RVA = "0x25F0518", Offset = "0x25F0518", VA = "0x7BBCDF0518")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B80")]
		[Address(RVA = "0x25F0528", Offset = "0x25F0528", VA = "0x7BBCDF0528")]
		public DownloadContext(ResDownloadType type, int maxLoaderCountSimultaneously)
		{
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B81")]
		[Address(RVA = "0x25F05D4", Offset = "0x25F05D4", VA = "0x7BBCDF05D4", Slot = "4")]
		public virtual void Clear()
		{
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B82")]
		[Address(RVA = "0x25F061C", Offset = "0x25F061C", VA = "0x7BBCDF061C")]
		public void InitContext()
		{
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B83")]
		[Address(RVA = "0x25F0628", Offset = "0x25F0628", VA = "0x7BBCDF0628")]
		public void AddLoader(ResFileLoader load, bool is_Retry = false, long progress_size = -1L)
		{
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B84")]
		[Address(RVA = "0x25F06B8", Offset = "0x25F06B8", VA = "0x7BBCDF06B8", Slot = "5")]
		public virtual void PauseDownload(bool isPause)
		{
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B85")]
		[Address(RVA = "0x25F0710", Offset = "0x25F0710", VA = "0x7BBCDF0710", Slot = "6")]
		public virtual void StartDownload([Optional] Action<ResErrorCode, ResDownloadType> callback)
		{
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B86")]
		[Address(RVA = "0x25F07D0", Offset = "0x25F07D0", VA = "0x7BBCDF07D0", Slot = "7")]
		public virtual void InvokeFinishCallBack()
		{
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B87")]
		[Address(RVA = "0x25F083C", Offset = "0x25F083C", VA = "0x7BBCDF083C")]
		public void Update(float time)
		{
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x00012930 File Offset: 0x00010B30
		[Token(Token = "0x6003B88")]
		[Address(RVA = "0x25F08B4", Offset = "0x25F08B4", VA = "0x7BBCDF08B4")]
		public bool HaveEnoughStorage()
		{
			return default(bool);
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x00012948 File Offset: 0x00010B48
		[Token(Token = "0x6003B89")]
		[Address(RVA = "0x25F093C", Offset = "0x25F093C", VA = "0x7BBCDF093C")]
		public bool IsUnZipping()
		{
			return default(bool);
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B8A")]
		[Address(RVA = "0x25F0994", Offset = "0x25F0994", VA = "0x7BBCDF0994")]
		public ResVersionInfo.FileInfo CurrentDownloadFileInfo()
		{
			return null;
		}

		// Token: 0x04004D1B RID: 19739
		[Token(Token = "0x4004D1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ResDownloadType DownloadType;

		// Token: 0x04004D1C RID: 19740
		[Token(Token = "0x4004D1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<ResErrorCode, ResDownloadType> FinishedCallBack;

		// Token: 0x04004D1D RID: 19741
		[Token(Token = "0x4004D1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ResUpdaterProgressMonitor UpdateProgressMonitor;

		// Token: 0x04004D1E RID: 19742
		[Token(Token = "0x4004D1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ResFileLoaderController LoaderController;

		// Token: 0x04004D1F RID: 19743
		[Token(Token = "0x4004D1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ResErrorCode LastError;

		// Token: 0x04004D20 RID: 19744
		[Token(Token = "0x4004D20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E954", Offset = "0x112E954")]
		private EDownloadContextState <State>k__BackingField;

		// Token: 0x04004D21 RID: 19745
		[Token(Token = "0x4004D21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long TotalNeedDownloadSize;

		// Token: 0x04004D22 RID: 19746
		[Token(Token = "0x4004D22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long TotalRequireSize;
	}
}
