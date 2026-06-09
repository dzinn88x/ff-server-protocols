using System;
using System.Runtime.Serialization.Formatters.Binary;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F25 RID: 3877
	[Token(Token = "0x2000F25")]
	internal class LocalSaveData<T> where T : new()
	{
		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06003762 RID: 14178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C3")]
		private string DefaultSavedPath
		{
			[Token(Token = "0x6003762")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06003763 RID: 14179 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003764 RID: 14180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C4")]
		public T CurrentSaveData
		{
			[Token(Token = "0x6003763")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003764")]
			set
			{
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06003765 RID: 14181 RVA: 0x00011328 File Offset: 0x0000F528
		// (set) Token: 0x06003766 RID: 14182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C5")]
		private int CurrentSaveSlot
		{
			[Token(Token = "0x6003765")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B82C", Offset = "0x113B82C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003766")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B83C", Offset = "0x113B83C")]
			set
			{
			}
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003767")]
		public LocalSaveData()
		{
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x00011340 File Offset: 0x0000F540
		[Token(Token = "0x6003768")]
		public bool Save(int saveSlot = 0)
		{
			return default(bool);
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x00011358 File Offset: 0x0000F558
		[Token(Token = "0x6003769")]
		public bool Load(int saveSlot = 0)
		{
			return default(bool);
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x00011370 File Offset: 0x0000F570
		[Token(Token = "0x600376A")]
		private bool SaveInternal(int saveSlot = 0)
		{
			return default(bool);
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600376B")]
		private string GetSaveFileFullPath(int saveSlot)
		{
			return null;
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600376C")]
		private string GetTmpFile()
		{
			return null;
		}

		// Token: 0x040049FD RID: 18941
		[Token(Token = "0x40049FD")]
		[FieldOffset(Offset = "0x0")]
		private int m_TmpFileIndex;

		// Token: 0x040049FE RID: 18942
		[Token(Token = "0x40049FE")]
		[FieldOffset(Offset = "0x0")]
		private BinaryFormatter m_BinaryFormatter;

		// Token: 0x040049FF RID: 18943
		[Token(Token = "0x40049FF")]
		[FieldOffset(Offset = "0x0")]
		private T m_CurrentSaveData;

		// Token: 0x04004A00 RID: 18944
		[Token(Token = "0x4004A00")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E8A4", Offset = "0x112E8A4")]
		private int <CurrentSaveSlot>k__BackingField;

		// Token: 0x04004A01 RID: 18945
		[Token(Token = "0x4004A01")]
		[FieldOffset(Offset = "0x0")]
		private byte[] InitVectorKeys;

		// Token: 0x04004A02 RID: 18946
		[Token(Token = "0x4004A02")]
		[FieldOffset(Offset = "0x0")]
		private byte[] Keys;

		// Token: 0x04004A03 RID: 18947
		[Token(Token = "0x4004A03")]
		[FieldOffset(Offset = "0x0")]
		public LocalSaveData<T>.OnLoadFinished LoadFinishedAction;

		// Token: 0x04004A04 RID: 18948
		[Token(Token = "0x4004A04")]
		[FieldOffset(Offset = "0x0")]
		public LocalSaveData<T>.OnBeforeSave BeforeSaveAction;

		// Token: 0x04004A05 RID: 18949
		[Token(Token = "0x4004A05")]
		[FieldOffset(Offset = "0x0")]
		public LocalSaveData<T>.OnSaveFailed SaveFailedAction;

		// Token: 0x02000F26 RID: 3878
		// (Invoke) Token: 0x0600376E RID: 14190
		[Token(Token = "0x2000F26")]
		public delegate void OnLoadFinished();

		// Token: 0x02000F27 RID: 3879
		// (Invoke) Token: 0x06003772 RID: 14194
		[Token(Token = "0x2000F27")]
		public delegate void OnBeforeSave();

		// Token: 0x02000F28 RID: 3880
		// (Invoke) Token: 0x06003776 RID: 14198
		[Token(Token = "0x2000F28")]
		public delegate void OnSaveFailed();
	}
}
