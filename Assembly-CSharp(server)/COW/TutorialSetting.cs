using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200168D RID: 5773
	[Token(Token = "0x200168D")]
	public class TutorialSetting
	{
		// Token: 0x060068DF RID: 26847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DF")]
		[Address(RVA = "0x1A32B78", Offset = "0x1A32B78", VA = "0x7BBC232B78")]
		public TutorialSetting(TutorialEventEnum eType, TutorialUIType dType, string hint, bool finishByUser, string param, bool openToNewBie, bool inShowToVeteran, bool inWaitingRoom, List<uint> eMatchMode, List<uint> eGameMode, List<uint> eGroupMode, bool showLauncher, float delay)
		{
		}

		// Token: 0x040085EE RID: 34286
		[Token(Token = "0x40085EE")]
		[FieldOffset(Offset = "0x10")]
		public TutorialEventEnum eventType;

		// Token: 0x040085EF RID: 34287
		[Token(Token = "0x40085EF")]
		[FieldOffset(Offset = "0x14")]
		public TutorialUIType displayType;

		// Token: 0x040085F0 RID: 34288
		[Token(Token = "0x40085F0")]
		[FieldOffset(Offset = "0x18")]
		public float hideDelay;

		// Token: 0x040085F1 RID: 34289
		[Token(Token = "0x40085F1")]
		[FieldOffset(Offset = "0x20")]
		public string hintText;

		// Token: 0x040085F2 RID: 34290
		[Token(Token = "0x40085F2")]
		[FieldOffset(Offset = "0x28")]
		public string paramText;

		// Token: 0x040085F3 RID: 34291
		[Token(Token = "0x40085F3")]
		[FieldOffset(Offset = "0x30")]
		public bool finishWhenUserInteract;

		// Token: 0x040085F4 RID: 34292
		[Token(Token = "0x40085F4")]
		[FieldOffset(Offset = "0x31")]
		public bool isOpenToNewBie;

		// Token: 0x040085F5 RID: 34293
		[Token(Token = "0x40085F5")]
		[FieldOffset(Offset = "0x32")]
		public bool showToVeteran;

		// Token: 0x040085F6 RID: 34294
		[Token(Token = "0x40085F6")]
		[FieldOffset(Offset = "0x33")]
		public bool canShowInWaitingRoom;

		// Token: 0x040085F7 RID: 34295
		[Token(Token = "0x40085F7")]
		[FieldOffset(Offset = "0x34")]
		public bool showEveryLauncher;

		// Token: 0x040085F8 RID: 34296
		[Token(Token = "0x40085F8")]
		[FieldOffset(Offset = "0x38")]
		public List<uint> matchMode;

		// Token: 0x040085F9 RID: 34297
		[Token(Token = "0x40085F9")]
		[FieldOffset(Offset = "0x40")]
		public List<uint> gameMode;

		// Token: 0x040085FA RID: 34298
		[Token(Token = "0x40085FA")]
		[FieldOffset(Offset = "0x48")]
		public List<uint> groupMode;
	}
}
