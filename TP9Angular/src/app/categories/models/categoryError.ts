export class CategoryError extends Error {
    status = 400;
  
    constructor(status: number, message: string) {
      super(message);
  
      this.status = status;

      Object.setPrototypeOf(this, CategoryError.prototype);
    }

    getErrorMessage() {
        return 'There was an error: ' + this.message;
    }
}