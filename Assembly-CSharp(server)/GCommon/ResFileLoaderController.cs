using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FD2 RID: 4050
	[Token(Token = "0x2000FD2")]
	public class ResFileLoaderController
	{
		// Token: 0x06003B6E RID: 15214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6E")]
		[Address(RVA = "0x2962770", Offset = "0x2962770", VA = "0x7BBD162770")]
		public ResFileLoaderController(int maxLoaderCountSimultaneously)
		{
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6F")]
		[Address(RVA = "0x296283C", Offset = "0x296283C", VA = "0x7BBD16283C")]
		public void AddLoader(ResFileLoader loader, bool addToFirst = false)
		{
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B70")]
		[Address(RVA = "0x29628DC", Offset = "0x29628DC", VA = "0x7BBD1628DC")]
		public void RemoveLoader(ResFileLoader loader)
		{
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B71")]
		[Address(RVA = "0x29629D4", Offset = "0x29629D4", VA = "0x7BBD1629D4")]
		public void Clear()
		{
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x00012870 File Offset: 0x00010A70
		[Token(Token = "0x6003B72")]
		[Address(RVA = "0x2962AE4", Offset = "0x2962AE4", VA = "0x7BBD162AE4")]
		public float GetSizeLoaded()
		{
			return 0f;
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B73")]
		[Address(RVA = "0x2962AF0", Offset = "0x2962AF0", VA = "0x7BBD162AF0")]
		public void PauseDownload(bool isPause)
		{
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x00012888 File Offset: 0x00010A88
		[Token(Token = "0x6003B74")]
		[Address(RVA = "0x2962BC8", Offset = "0x2962BC8", VA = "0x7BBD162BC8")]
		public long Update(float time)
		{
			return 0L;
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x000128A0 File Offset: 0x00010AA0
		[Token(Token = "0x6003B75")]
		[Address(RVA = "0x2963080", Offset = "0x2963080", VA = "0x7BBD163080")]
		public bool IsFinished()
		{
			return default(bool);
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x000128B8 File Offset: 0x00010AB8
		[Token(Token = "0x6003B76")]
		[Address(RVA = "0x296311C", Offset = "0x296311C", VA = "0x7BBD16311C")]
		public bool IsRuningUnZip()
		{
			return default(bool);
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B77")]
		[Address(RVA = "0x296320C", Offset = "0x296320C", VA = "0x7BBD16320C")]
		public ResVersionInfo.FileInfo CurrentDownloadFileInfo()
		{
			return null;
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B78")]
		[Address(RVA = "0x2963314", Offset = "0x2963314", VA = "0x7BBD163314")]
		public List<ResVersionInfo.FileInfo> GetFileInfoList()
		{
			return null;
		}

		// Token: 0x04004CEA RID: 19690
		[Token(Token = "0x4004CEA")]
		[FieldOffset(Offset = "0x10")]
		private int m_MaxLoaderCountSimultaneously;

		// Token: 0x04004CEB RID: 19691
		[Token(Token = "0x4004CEB")]
		[FieldOffset(Offset = "0x14")]
		private bool m_IsPause;

		// Token: 0x04004CEC RID: 19692
		[Token(Token = "0x4004CEC")]
		[FieldOffset(Offset = "0x18")]
		private long m_SizeLoaded;

		// Token: 0x04004CED RID: 19693
		[Token(Token = "0x4004CED")]
		[FieldOffset(Offset = "0x20")]
		private LinkedList<ResFileLoader> m_Loaders;

		// Token: 0x04004CEE RID: 19694
		[Token(Token = "0x4004CEE")]
		[FieldOffset(Offset = "0x28")]
		private LinkedList<ResFileLoader> m_RunningLoaders;

		// Token: 0x04004CEF RID: 19695
		[Token(Token = "0x4004CEF")]
		[FieldOffset(Offset = "0x30")]
		private List<ResFileLoader> m_FinishedLoader;
	}
}
